using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Price Price 8: 0.01 - 9,999.99
    /// </summary>

    public struct PricePrice8
    {
        /// <summary>
        ///  Decimal place factor for Price Price 8
        /// </summary>
        public const long Factor = 100000000;

        /// <summary>
        ///  Size of Price Price 8 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Price Price 8 value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Price Price 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Price Price 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Price Price 8 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}