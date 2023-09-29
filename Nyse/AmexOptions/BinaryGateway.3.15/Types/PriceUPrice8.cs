using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Price U Price 8: Order entry Limit price range for the MPVLevel
    /// </summary>

    public struct PriceUPrice8
    {
        /// <summary>
        ///  Decimal place factor for Price U Price 8
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Price U Price 8 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Price U Price 8 value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Price U Price 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Price U Price 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Price U Price 8 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}