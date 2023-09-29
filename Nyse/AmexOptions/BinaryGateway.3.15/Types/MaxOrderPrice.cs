using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Max Order Price: Maximum allowable order entry price
    /// </summary>

    public struct MaxOrderPrice
    {
        /// <summary>
        ///  Decimal place factor for Max Order Price
        /// </summary>
        public const long Factor = 100000000;

        /// <summary>
        ///  Size of Max Order Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Max Order Price value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Max Order Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Max Order Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Max Order Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}