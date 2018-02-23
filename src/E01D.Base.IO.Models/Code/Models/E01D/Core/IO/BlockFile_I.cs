using System.Collections.Generic;

namespace Root.Code.Models.E01D.Core.IO
{
    public interface BlockFile_I
    {
        long Position { get; set; }

        List<Block_I> Blocks { get; set; } 

        long Length { get; set; }
    }
}
