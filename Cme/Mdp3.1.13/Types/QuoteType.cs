namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Quote Type: One Byte Fixed Width Integer
    /// </summary>

    public struct QuoteType
    {
        /// <summary>
        ///  Fix Tag for Quote Type
        /// </summary>
        public const ushort FixTag = 537;

        /// <summary>
        ///  Length of Quote Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}