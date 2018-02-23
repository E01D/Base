using Root.Coding.Code.Models.E01D.Base.Configurational.Data;
using Root.Coding.Code.Models.E01D.Base.Security.Contextual;
using Root.Coding.Code.Models.E01D.Base.Transactions;

namespace Root.Coding.Code.Models.E01D
{
    public class StandardContext : SecurityContextHost_I, TransactionContextHost_I, ConnectionStringContextHost_I
    {
        SecurityContext_I SecurityContextHost_I.Security { get; set; }

        TransactionalContext_I TransactionContextHost_I.Transactional { get; set; }

        ConnectionStringContext_I ConnectionStringContextHost_I.ConnectionStrings { get; set; } = new ConnectionStringContext();
    }
}
