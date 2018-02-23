using Root.Coding.Code.Models.E01D.Base.Identification;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Models.E01D.Base.Pocos
{
    public class Poco: Poco_I
    {


        // Gather all objects from previous state
        // (SELECT * FROM Something s INNER JOIN [Objects] o on s.InstanceId = o.InstanceId WHERE o.Active = 1 s.Id = x) * N

        // Insert new state as inactive objects
        // {
        //      INSERT INTO Something (InstanceId, Id, TransactionId, A, B, C) VALUES (x, y, z, a, b, c)
        //      INSERT INTO Objects (InstanceId, Id, TransactionId, IsActive) VALUES (x, y, z, 0)
        // } * N
        // Switch all previous  new state as inactive objects
        // BEGIN TRANSACTION
        // (UPDATE [Objects] SET o.Active = 0 WHERE o.ID = x AND o.TransactionId <> y) * N Objects
        // (UPDATE [Objects] SET o.Active = 1 WHERE o.ID = x AND o.TransactionId = y) * N Objects
        // COMMIT TRRANSACTION

        // Only Table that is locked temporarily is objects when objects flip from inactive to active.  
        public VersionId_I VersionId { get; set; }
        public TransactionId_I TransactionId { get; set; }
        public PocoStatus_I Status { get; set; }

        /// <summary>
        /// Gets or sets the organization id owning this object.
        /// </summary>
        public OwnerOrganizationId_I OwnerOrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the container id containing this object.
        /// </summary>
        public ContainerId_I ContainerId { get; set; }

        public Id_I Id { get; set; }

        public TypeId_I TypeId { get; set; }


    }
}
