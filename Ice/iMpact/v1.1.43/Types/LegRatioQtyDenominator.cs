using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Ratio Qty Denominator: Leg Ratio Qty Denominator
    /// </summary>

    public struct LegRatioQtyDenominator
    {
        /// <summary>
        ///  Size of Leg Ratio Qty Denominator in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Leg Ratio Qty Denominator value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Leg Ratio Qty Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Leg Ratio Qty Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Leg Ratio Qty Denominator as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}