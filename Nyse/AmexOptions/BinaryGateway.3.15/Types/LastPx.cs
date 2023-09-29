using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Last Px: Price of current partial fill or fill message 0.01 - 9,999.99
    /// </summary>

    public struct LastPx
    {
        /// <summary>
        ///  Decimal place factor for Last Px
        /// </summary>
        public const long Factor = 100000000;

        /// <summary>
        ///  Size of Last Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Last Px value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Last Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Last Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Last Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}