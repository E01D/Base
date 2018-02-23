namespace Root.Code.Models.E01D.Core.IO
{
    public interface Block_I
    {
        int Position { get; set; }

        long Address { get; set; }

        int Length { get; set; }

        byte[] Data { get; set; }
    }
}
