using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Security.Authorization
{
    public class Right:Poco, Right_I
    {
        // All organizations (members) in a organization Y get organanization right X assgigned to their objects
        // All organizations members in a role Y get organanization right X assgigned to their objects
        // All organizations members in a group Y get organanization right X assgigned to their objects (really don't need right now)

        // Case: All employees have been granted read access to everying inside or nested inside container Y.
        //       Means the right has to be assigned to every object and every sub organization and assigned to every member of the organization.
        //       Means the right has to be inherited by all organizations, and assgined to all objects and members of an organization.
        /// <summary>
        /// Gets or sets to which permission this right corresponds
        /// </summary>
        public long PermissionId { get; set; }

        

        

        
        //public long SourceGroupId { get; set; }

        //public long SourceRoleId { get; set; }

        public long SourceOrganizationId { get; set; }

        public long SourceRightId { get; set; }

        // Gets or sets the organization id associated with this right.  
        public long TargetOrganizationId { get; set; }

        // Gets or sets the actor id associated with this right
        public long TargetActorId { get; set; }

        /// <summary>
        /// Gets or sets what object is secured by this right.
        /// </summary>
        public long TargetObjectId { get; set; } // if zero, then affects all objects in teh organization, and other rights have a source right set to this right.

        /// <summary>
        /// Gets or sets whether the right is granting, revoking or disabled.
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// Gets or sets whether this right is inherited or not.
        /// </summary>
        public bool IsInherited { get; set; }


    }
}
