using Root.Coding.Code.Models.E01D.Base.Identification;

namespace Root.Coding.Code.Models.E01D.Base.Pocos
{
    public interface Poco_I:Ided_I
    {
        // Gather all objects from previous state
        // SELECT * FROM Something s INNER JOIN [Objects] o on s.TransactionId = o.TransactionId WHERE o.Active = 1 s.Id = x

        // Insert new state as inactive objects

        // Switch all previous  new state as inactive objects
        // BEGIN TRRANSACTION
        // (UPDATE [Objects] SET o.Active = 0 WHERE o.ID = x AND o.TransactionId <> y) * N Objects
        // UPDATE [Objects] SET o.Active = 1 WHERE o.TransactionId = y
        // END TRRANSACTION


        VersionId_I VersionId { get; set; }

        TransactionId_I TransactionId { get; set; }

        PocoStatus_I Status { get; set; }

        /// <summary>
        /// Gets or sets the organization id owning this object.
        /// </summary>
        OwnerOrganizationId_I OwnerOrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the container id containing this object.
        /// </summary>
        ContainerId_I ContainerId { get; set; }
    }
}
