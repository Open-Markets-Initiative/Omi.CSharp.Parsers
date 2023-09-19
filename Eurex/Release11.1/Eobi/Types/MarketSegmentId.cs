using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Market Segment Id
    /// </summary>

    public unsafe struct MarketSegmentId
    {
        /// <summary>
        ///  Size of Market Segment Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Market Segment Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}