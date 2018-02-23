using Root.Code.Api.E01D.Core.Collections;


namespace Root.Code.Domains.E01D
{
    public static class XCollections
    {
        static XCollections()
        {
            
        }

        

        

        public static LinkedListApi DoubleLinkedLists { get; set; } = new LinkedListApi();

        public static EnumerableApi Enumerables { get; set; } = new EnumerableApi();

        public static ExceptionApi Exceptions { get; set; } = new ExceptionApi();

        public static LinkedListApi LinkedLists { get; set; } = new LinkedListApi();

        

       

        public static SortingApi Sorting { get; set; } = new SortingApi();

        

        public static string GetResourceString(string resourceName)
        {
            return null;

            // see: https://github.com/dotnet/coreclr/blob/748d467b1cbc759c23d94de0b559d9a437623b38/src/mscorlib/src/System.Private.CoreLib.txt

        }

        public static string GetResourceString(string resourceName, string argument)
        {
            return null;

            // see: https://github.com/dotnet/coreclr/blob/748d467b1cbc759c23d94de0b559d9a437623b38/src/mscorlib/src/System.Private.CoreLib.txt

        }

       
    }
}
