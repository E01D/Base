namespace Root.Coding.Code.Models.E01D.Core.Data.Framework
{
    public class DbCategoryAttribute:System.Attribute
    {
        public DbCategoryAttribute(string dbCategoryName)
        {
            DbCategoryName = dbCategoryName;
        }

        /// <summary>
        /// Gets or sets the database category name that is associated
        /// </summary>
        public string DbCategoryName { get; set; }
    }
}
