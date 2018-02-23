using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Associations;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class AssociationApi: AssociationApi_I
    {
        public bool Exists(long from, long to, long typaId)
        {
            var api = (AssociationApi_I)XData.GetApi<Association_I>();

            return false;
        }

        public Association_I Associate(Poco_I pocoFrom, Poco_I pocoTo, long associationTypaId)
        {
            var api = (AssociationApi_I)XData.GetApi<Association_I>();

            return api.Associate(pocoFrom, pocoTo, associationTypaId);
        }

        public void Disassociate(Poco_I pocoFrom, Poco_I pocoTo, long associationTypaId)
        {
            var api = (AssociationApi_I)XData.GetApi<Association_I>();

            api.Disassociate(pocoFrom, pocoTo, associationTypaId);
        }

        public void Disassociate(Association_I association)
        {
            var api = (AssociationApi_I)XData.GetApi<Association_I>();

            api.Disassociate(association);
        }

        public List<Poco_I> GetAllFrom(long fromId)
        {
            var api = (AssociationApi_I) XData.GetApi<Association_I>();

            // From type id, get data api
            return api.GetAllFrom(fromId);
        }

        public List<Poco_I> GetAllTo(long toId)
        {
            var api = (AssociationApi_I)XData.GetApi<Association_I>();

            // From type id, get data api
            return api.GetAllTo(toId);
        }

        public List<Poco_I> GetAllFrom(long fromId, long associtionTypaId)
        {
            var api = (AssociationApi_I)XData.GetApi<Association_I>();

            // From type id, get data api
            return api.GetAllFrom(fromId, associtionTypaId);
        }

        public List<Poco_I> GetAllTo(long toId, long associtionTypaId)
        {
            var api = (AssociationApi_I)XData.GetApi<Association_I>();

            // From type id, get data api
            return api.GetAllTo(toId, associtionTypaId);
        }

        public Poco_I GetById(long id)
        {
            var api = (AssociationApi_I)XData.GetApi<Association_I>();

            // From type id, get data api
            return api.GetById(id);
        }
    }
}
