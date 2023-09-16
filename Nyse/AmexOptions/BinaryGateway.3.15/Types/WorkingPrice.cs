using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Working Price: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct WorkingPrice
    {
        /// <summary>
        ///  Length of Working Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Working Price
        /// </summary>
        public const int Factor = 100000000;
    }
}