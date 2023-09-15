namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Market Depth: One Byte Fixed Width Integer
    /// </summary>

    public struct MarketDepth
    {
        /// <summary>
        ///  Fix Tag for Market Depth
        /// </summary>
        public const ushort FixTag = 264;

        /// <summary>
        ///  Length of Market Depth in bytes
        /// </summary>
        public const int Length = 1;
    }
}