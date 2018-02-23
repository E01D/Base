using Root.Coding.Code.Models.E01D.Base.Data;

namespace Root.Coding.Code.Models.E01D.Core.Data.Sql
{
    /// <summary>
    /// A type can be an entity in a database.  That entity can in structure differ from the type it is in the database.
    /// </summary>
    public class SqlDataEntityContext:DataEntityContext
    {
        /// <summary>
        /// Gets or sets the select all sql used to select all instances of the entity.
        /// </summary>
        public string SelectAllSql { get; set; }

        /// <summary>
        /// Gets or sets the select sql used to select a instance of the entity.
        /// </summary>
        public string SelectSql { get; set; }

        /// <summary>
        /// Gets or sets the insert sql used to insert a instance of the entity.
        /// </summary>
        public string InsertSql { get; set; }

        /// <summary>
        /// Gets or sets the update sql used to update a instance of the entity.
        /// </summary>
        public string UpdateSql { get; set; }

        /// <summary>
        /// Gets or sets the remove sql used to remove all instances of the entity.
        /// </summary>
        public string RemoveAllSql { get; set; }

        public string RemoveSql { get; set; }

        public string PrimaryKeyName { get; set; } = "Id";
    }
}
