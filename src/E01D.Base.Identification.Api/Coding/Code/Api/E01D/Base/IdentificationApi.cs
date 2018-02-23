using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Exceptions.E01D.Base.Identification;
using Root.Coding.Code.Models.E01D.Base.Identification;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class IdentificationApi:IdentificationApi_I
    {
        private const string LastIdIssuedKey = "E01D:Base:Identification:LastIdIssued";

        public void Initialize()
        {
            var context = GetHost();

            if (context.Identification == null)
            {
                context.Identification = new IdContext();
            }

            Initialize(context.Identification);
        }

        public IdContextHost_I GetHost()
        {
            var context = XContextualBase.GetGlobalAs<IdContextHost_I>();

            if (context == null)
            {
                throw new IdentificationSubSystemNotSupportedException();
            };

            return context;
        }

        public IdContext_I CreateContext()
        {
            return new IdContext();
        }

        public Id_I IssueId()
        {
            var host = GetHost();

            var context = host.Identification;

            return IssueId(context);
        }

        public T IssueId<T>()
            where T : Identifier_I
        {
            var host = GetHost();

            var context = host.Identification;

            T id;

            IssueId<T>(context, out id);

            return id;
        }

        public void IssueId<T>(T identifier)
            where T : Identifier_I
        {
            var host = GetHost();

            var context = host.Identification;

            IssueId<T>(context, identifier);
        }

        public Id_I IssueId(IdContext_I context)
        {
            StandardId standardId = new StandardId();

            IssueId(context, standardId);

            return standardId;
        }

        public bool IssueId<T>(IdContext_I context, out T id)
            where T:Identifier_I
        {
            lock (context.SyncRoot)
            {
                id = XNew.New<T>();

                return IssueId<T>(context, id);
            }
        }

        public bool IssueId<T>(IdContext_I context, T identifier)
            where T : Identifier_I
        {
            lock (context.SyncRoot)
            {
                bool availableRangeUpdated = false;

                if (context.AvailableRange == null || context.AvailableRange.LastIssuedId >= context.AvailableRange.EndInclusive || context.AvailableRange.StartInclusive == 0 || context.AvailableRange.EndInclusive == 0)
                {
                    context.AvailableRange = IssueNextAvailableRange(context);

                    XSettings.SetAndPersist(LastIdIssuedKey, context.AvailableRange.EndInclusive.ToString());

                    availableRangeUpdated = true;
                }

                identifier.Value = (++context.AvailableRange.LastIssuedId);

                return availableRangeUpdated;
            }
        }


        public AvailableIdRange_I IssueNextAvailableRange(IdContext_I context)
        {
            var newRange = IssueRange(context, context.DefaultIdRangeSize);

            var availableRange = new AvailableIdRange()
            {
                LastIssuedId = newRange.StartInclusive - 1,
                StartInclusive = newRange.StartInclusive,
                EndInclusive = newRange.EndInclusive
            };

            context.AvailableRange = availableRange;

            return availableRange;
        }

        public IdRange_I IssueRange()
        {
            var host = GetHost();

            return IssueRange(host.Identification, host.Identification.DefaultIdRangeSize);
        }

        public IdRange_I IssueRange(int size)
        {
            var host = GetHost();

            return IssueRange(host.Identification, size);
        }

        public IdRange_I IssueRange(IdContextHost_I host, int size)
        {
            return IssueRange(host.Identification, size);
        }

        public IdRange_I IssueRange(IdContext_I context, int size)
        {
            lock (context.SyncRoot)
            {
                var lastIdentifierIssued = context.AvailableRange.LastIssuedId;

                var start = lastIdentifierIssued + 1;

                var stop = start - 1 + size;

                var range = new IdRange()
                {
                    EndInclusive = stop,
                    StartInclusive = start
                };

                context.AvailableRange.LastIssuedId = range.EndInclusive;

                return range;
            }
        }

        public T AssignId<T>(T objectToAssign)
            where T : Ided_I
        {
            var host = GetHost();

            AssignId(host.Identification, (Ided_I)objectToAssign);

            return objectToAssign;
        }

        public T AssignId<T>(IdContext_I context, T objectToAssign)
            where T : Ided_I
        {
            AssignId(context, (Ided_I)objectToAssign);

            return objectToAssign;
        }

        public Ided_I AssignId(IdContext_I context, Ided_I objectToAssign)
        {
            IssueId(context, out Id_I id);

            objectToAssign.Id = id;

            return objectToAssign;
        }

        public Ided_I AssignId(IdContextHost_I context, Ided_I objectToAssign)
        {
            return AssignId(context.Identification, objectToAssign);
        }

        public void Initialize(IdContext_I context)
        {
            if (XSettings.GetString(LastIdIssuedKey, out string lastIdIssued) &&
                !string.IsNullOrEmpty(lastIdIssued) &&
                Int64.TryParse(lastIdIssued, out long lastId))
            {
                context.AvailableRange = new AvailableIdRange()
                {
                    LastIssuedId = lastId
                };

                return;   
            }

            XSettings.SetAndPersist(LastIdIssuedKey, "0");

            context.AvailableRange = new AvailableIdRange()
            {
                LastIssuedId = 0
            };
        }


        public Id_I NewId(object castToLongId)
        {
            return new StandardId()
            {
                Value = (long) castToLongId
            };
        }
    }
}
