using System;
using Root.Coding.Code.Api.E01D.NetFramework.ObjectCreation.LogMessages;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Messaging.Messages;

namespace Root.Coding.Code.Api.E01D.NetFramework.ObjectCreation
{
    public class ObjectFactoryApi:ObjectFactoryApi_I
    {
        public object New(Type type)
        {
            try
            {
                var x = type.GetConstructor(System.Type.EmptyTypes);

                if (x == null)
                {
                    // Need to be using an log message type so that the exceptions can be filtered by a more advnced logging package.  This gets rid of the need to pass in a global context,
                    // as a more advanced logging system can filter the messages by type if it needed to adjust the verbosity.
                    XLogBase.LogError(null, new NoPublicConstructorsWithEmptyArguementsLogMessage()
                    {
                        Message = new Message()
                        {
                            Value = $"There are no public empty argument constructors for type '{type.AssemblyQualifiedName}'.  An instance could not be created."
                        }
                    });

                    //XLogBase.LogError(XContextualBase.GetGlobal(), $"There are no public empty argument constructors for type '{type.AssemblyQualifiedName}'.  An instance could not be created.");



                    return null;
                }

                return x.Invoke(null);

            }
            catch (System.Exception exception)
            {
                //XLogBase.LogException(XContextualBase.GetGlobal(), exception);

                XLogBase.LogException(null, exception);

                return null;
            }
        }
    }
}
