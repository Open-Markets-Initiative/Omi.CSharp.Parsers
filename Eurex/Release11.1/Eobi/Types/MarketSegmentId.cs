using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Market Segment Id:
    /// </summary>

    public unsafe struct MarketSegmentId
    {
        /// <summary>
        ///  Length of Market Segment Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}