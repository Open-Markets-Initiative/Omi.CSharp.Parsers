using using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Is Implied Spread At Market Open: Indicate if the trade happens at market open due to spread implied. When set to ‘Y’, such deal should not be included in market stats.
    /// </summary>

    public struct IsImpliedSpreadAtMarketOpen
    {
        /// <summary>
        ///  Size of Is Implied Spread At Market Open in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Is Implied Spread At Market Open value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Is Implied Spread At Market Open
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Is Implied Spread At Market Open as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}