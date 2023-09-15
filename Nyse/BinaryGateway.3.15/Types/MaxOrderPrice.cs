namespace Nyse.AmexOptions.Pillar
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Max Order Price: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct MaxOrderPrice
    {
        /// <summary>
        ///  Length of Max Order Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Max Order Price
        /// </summary>
        public const int Factor = 100000000;
    }
}