using Root.Code.Exts.E01D.IO;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class StringApi
    {
        public void Write(Block_I block, string stringToWrite)
        {
            var iLength = stringToWrite.Length;

            block.Write(iLength);

            for (var i = 0; i < iLength; i++)
            {
                block.Write((byte)(stringToWrite[i] & 0xff));
            }
        }

        public void Read(Block_I block, out string stringToRead)
        {
            long iLength;

            block.Read(out iLength);

            if (iLength == 0)
            {
                stringToRead = string.Empty;

                return;
            }

            var oChars = new char[iLength];

            for (var ii = 0; ii < iLength; ii++)
            {
                short currentShort;

                block.Read(out currentShort);

                oChars[ii] = (char) currentShort;
            }

            stringToRead = new string(oChars);
        }
    }
}
