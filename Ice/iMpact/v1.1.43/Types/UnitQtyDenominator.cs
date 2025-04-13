using System.Runtime.CompilerServices;

namespace Ice.iMpact
{

    /// <summary>
    ///  Unit Qty Denominator: Denominator for UnitQuantity. This field will be ‘0’ for most of the markets.
    /// </summary>

    public struct UnitQtyDenominator
    {
        /// <summary>
        ///  Size of Unit Qty Denominator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Unit Qty Denominator value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Unit Qty Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Unit Qty Denominator as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}