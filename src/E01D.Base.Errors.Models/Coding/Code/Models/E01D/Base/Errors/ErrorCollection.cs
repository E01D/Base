using System.Collections.Generic;



namespace Root.Coding.Code.Models.E01D.Base.Errors
{
    public class ErrorCollection
    {
        public long Id { get; set; }

        public List<Error_I> Items { get; set; } = new List<Error_I>();
        
        public long TypaId { get; set; }
    }
}
