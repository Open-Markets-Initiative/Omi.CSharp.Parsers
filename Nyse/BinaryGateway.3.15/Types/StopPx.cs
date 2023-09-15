namespace Nyse.AmexOptions.Pillar
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Stop Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct StopPx
    {
        /// <summary>
        ///  Length of Stop Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Stop Px
        /// </summary>
        public const int Factor = 100000000;
    }
}