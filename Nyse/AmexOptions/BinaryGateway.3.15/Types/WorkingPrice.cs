using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Working Price: 0.01- 9,999.99
    /// </summary>

    public struct WorkingPrice
    {
        /// <summary>
        ///  Decimal place factor for Working Price
        /// </summary>
        public const long Factor = 100000000;

        /// <summary>
        ///  Size of Working Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Working Price value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Working Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Working Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Working Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}