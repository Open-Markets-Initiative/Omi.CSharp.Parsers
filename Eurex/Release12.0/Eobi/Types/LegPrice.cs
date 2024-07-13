using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Price
    /// </summary>

    public struct LegPrice
    {
        /// <summary>
        ///  Maximum value for Leg Price
        /// </summary>
        public const ulong Maximum = 92233720368.54775807;

        /// <summary>
        ///  Minimum value for Leg Price
        /// </summary>
        public const ulong Minimum = -92233720368.54775807;

        /// <summary>
        ///  Decimal place factor for Leg Price
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Leg Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Leg Price value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Leg Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Leg Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Leg Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}