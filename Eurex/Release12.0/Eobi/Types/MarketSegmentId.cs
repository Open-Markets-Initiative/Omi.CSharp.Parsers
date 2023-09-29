using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Market Segment Id
    /// </summary>

    public struct MarketSegmentId
    {
        /// <summary>
        ///  Size of Market Segment Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Market Segment Id value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying;

        /// <summary>
        ///  Write Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value;

        /// <summary>
        ///  Market Segment Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}