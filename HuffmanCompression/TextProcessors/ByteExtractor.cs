using System.Collections;

namespace HuffmanCompression.TextProcessors
{
    public static class ByteExtractor
    {
        public static byte[] GetBytes(BitArray bits)
        {
            var bytes = new byte[bits.Count];
            for (var i = 0; i < bits.Count; i++)
            {
                bytes[i] = bits[i] ? (byte)1 : (byte)0;
            }

            return bytes;
        }
        
        public static byte[] GetBytes(string bits)
        {
            var bytes = new byte[bits.Length];
            for (var i = 0; i < bits.Length; i++)
            {
                bytes[i] = bits[i] == '1' ? (byte)1 : (byte)0;
            }

            return bytes;
        }
    }
}