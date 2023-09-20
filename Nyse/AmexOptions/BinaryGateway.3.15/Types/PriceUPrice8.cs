using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Price U Price 8: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct PriceUPrice8
    {
        /// <summary>
        ///  Length of Price U Price 8 in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Price U Price 8
        /// </summary>
        public const int Factor = 100000000;
    }
}