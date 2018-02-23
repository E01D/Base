namespace Root.Code.Models.E01D.Core.IO
{
    public interface BlockStream_I
    {
        Block_I Block { get; set; }

        System.IO.Stream Stream { get; set; }


        
    }
}
