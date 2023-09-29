using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Stop Px: Trigger price for Stop and Stop Limit orders
    /// </summary>

    public struct StopPx
    {
        /// <summary>
        ///  Decimal place factor for Stop Px
        /// </summary>
        public const long Factor = 100000000;

        /// <summary>
        ///  Size of Stop Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Stop Px value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Stop Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Stop Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Stop Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}