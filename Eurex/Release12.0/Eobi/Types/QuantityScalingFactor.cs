using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Quantity Scaling Factor
    /// </summary>

    public struct QuantityScalingFactor
    {
        /// <summary>
        ///  Maximum value for Quantity Scaling Factor
        /// </summary>
        public const ushort Maximum = 1000;

        /// <summary>
        ///  Minimum value for Quantity Scaling Factor
        /// </summary>
        public const ushort Minimum = 1;

        /// <summary>
        ///  Size of Quantity Scaling Factor in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Quantity Scaling Factor value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Quantity Scaling Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Quantity Scaling Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Quantity Scaling Factor as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}