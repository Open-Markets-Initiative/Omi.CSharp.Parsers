using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Non Disclosed Trade Volume
    /// </summary>

    public struct NonDisclosedTradeVolume
    {
        /// <summary>
        ///  Decimal place factor for Non Disclosed Trade Volume
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Non Disclosed Trade Volume in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Non Disclosed Trade Volume value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Non Disclosed Trade Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Non Disclosed Trade Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Non Disclosed Trade Volume as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}