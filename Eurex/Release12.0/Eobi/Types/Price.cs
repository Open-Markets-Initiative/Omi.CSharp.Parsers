using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Price
    /// </summary>

    public struct Price
    {
        /// <summary>
        ///  Maximum value for Price
        /// </summary>
        public const ulong Maximum = 92233720368.54775807;

        /// <summary>
        ///  Minimum value for Price
        /// </summary>
        public const ulong Minimum = -92233720368.54775807;

        /// <summary>
        ///  Decimal place factor for Price
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Price value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}