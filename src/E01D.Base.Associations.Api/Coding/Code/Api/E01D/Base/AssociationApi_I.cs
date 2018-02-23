using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Associations;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Api.E01D.Base
{
    public interface AssociationApi_I
    {
        Association_I Associate(Poco_I from, Poco_I to, long associationTypaId);

        void Disassociate(Poco_I pocoFrom, Poco_I pocoTo, long associationTypaId);

        void Disassociate(Association_I association);

        bool Exists(long from, long to, long typaId);

        List<Poco_I> GetAllFrom(long fromId);

        List<Poco_I> GetAllTo(long toId);

        List<Poco_I> GetAllFrom(long fromId, long associtionTypaId);

        List<Poco_I> GetAllTo(long toId, long associtionTypaId);

        Poco_I GetById(long id);
    }
}
