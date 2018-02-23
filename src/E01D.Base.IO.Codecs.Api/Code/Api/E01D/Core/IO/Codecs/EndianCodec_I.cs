using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs
{
    public interface EndianCodec_I: EndianObjectCodec_I
    {
        

        

        void WriteBool(byte[] block, int offset, bool value);

        void WriteBool(Block_I block, bool value);

        new bool ReadBool(Block_I block);

        new bool ReadBool(byte[] block, int position);

        

        void WriteInt08(byte[] block, int offset, sbyte value);

        sbyte ReadInt08(byte[] block, int offset);

        

        void WriteInt08(Block_I block, sbyte value);

        sbyte ReadInt08(Block_I block);

        

        void WriteInt16(byte[] block, int offset, short value);

        

        void WriteInt16(Block_I block, short value);

        short ReadInt16(byte[] block, int offset);

        short ReadInt16(Block_I block);

        

        void WriteInt32(byte[] block, int offset, int value);

        

        void WriteInt32(Block_I block, int value);

        int ReadInt32(byte[] block, int offset);

        int ReadInt32(Block_I block);

        

        void WriteInt64(byte[] block, int offset, long value);

        

        void WriteInt64(Block_I block, long value);

        long ReadInt64(byte[] block, int offset);

        long ReadInt64(Block_I block);


        

        void WriteUInt08(byte[] block, int offset, byte value);

        byte ReadUInt08(byte[] block, int offset);

        

        void WriteUInt08(Block_I block, byte value);

        byte ReadUInt08(Block_I block);



        

        void WriteUInt16(byte[] block, int offset, ushort value);

        ushort ReadUInt16(byte[] block, int offset);

        

        void WriteUInt16(Block_I block, ushort value);

        ushort ReadUInt16(Block_I block);



        

        void WriteUInt32(byte[] block, int offset, uint value);

        uint ReadUInt32(byte[] block, int offset);

        

        void WriteUInt32(Block_I block, uint value);

        uint ReadUInt32(Block_I block);



        

        void WriteUInt64(byte[] block, int offset, ulong value);

        ulong ReadUInt64(byte[] block, int offset);

        

        void WriteUInt64(Block_I block, ulong value);

        ulong ReadUInt64(Block_I block);
    }
}
