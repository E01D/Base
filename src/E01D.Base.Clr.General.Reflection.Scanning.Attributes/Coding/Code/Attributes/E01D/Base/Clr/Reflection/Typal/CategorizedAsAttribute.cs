namespace Root.Coding.Code.Framework.E01D.Typing
{
    public class CategorizedAsAttribute
    {
        /// <summary>
        /// Used to categorize a type
        /// </summary>
        /// <param name="categoryType"></param>
        public CategorizedAsAttribute(System.Type categoryType)
        {
            CategoryType = categoryType;
        }

        public System.Type CategoryType { get; }
    }
}
