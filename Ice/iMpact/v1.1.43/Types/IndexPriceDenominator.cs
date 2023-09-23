using using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Index Price Denominator: This field should be applied to the Price field to get the number of decimals for the Marker/Index.
    /// </summary>

    public struct IndexPriceDenominator
    {
        /// <summary>
        ///  Size of Index Price Denominator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Index Price Denominator value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Index Price Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Index Price Denominator as string
        /// </summary>
        public override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}