using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Luldmpv: Numeric value of the Minimum Price Variation for LULD bands for securities belonging to the MPVClass.
    /// </summary>

    public struct Luldmpv
    {
        /// <summary>
        ///  Decimal place factor for Luldmpv
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Luldmpv in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Luldmpv value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Luldmpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Luldmpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Luldmpv as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}