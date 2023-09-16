using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Quantity Scaling Factor:
    /// </summary>

    public unsafe struct QuantityScalingFactor
    {
        /// <summary>
        ///  Length of Quantity Scaling Factor in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Quantity Scaling Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Quantity Scaling Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}