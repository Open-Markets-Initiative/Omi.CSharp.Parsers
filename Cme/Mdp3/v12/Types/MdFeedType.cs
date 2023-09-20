using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Feed Type: Describes a class of service for a given data feed. GBX- Real Book, GBI-Implied Book
    /// </summary>
    public unsafe struct MdFeedType
    {
        /// <summary>
        ///  Fix Tag for Md Feed Type
        /// </summary>
        public const ushort FixTag = 1022;

        /// <summary>
        ///  Size of Md Feed Type underlying field in bytes
        /// </summary>
        public const int Size = 3;

        /// <summary>
        ///  Read Md Feed Type from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Md Feed Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Size);

            for (var i = 0; i < end; i++)
            {
                Bytes[i] = (byte)value[i];
            }

            for (var i = end; i < Size; i++)
            {
                Bytes[i] = 0;
            }
        }

        /// <summary>
        ///  Md Feed Type as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}