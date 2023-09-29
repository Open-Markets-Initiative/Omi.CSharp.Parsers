using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Rpimpv: Numeric value of the Minimum Price Variation for Retail Price Improvement (RPI) orders for securities belonging to the MPVClass.
    /// </summary>

    public struct Rpimpv
    {
        /// <summary>
        ///  Decimal place factor for Rpimpv
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Rpimpv in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Rpimpv value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Rpimpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Rpimpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Rpimpv as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}