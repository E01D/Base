using System.Collections.Generic;


namespace Root.Coding.Code.Models.E01D.Base.Errors
{
    public interface ErrorCollection_I
    {
        long Id { get; set; }

        List<Error_I> Items { get; set; }

        long TypaId { get; set; }
    }
}
