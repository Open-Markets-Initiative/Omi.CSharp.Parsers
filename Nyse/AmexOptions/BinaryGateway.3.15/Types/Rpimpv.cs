using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Rpimpv: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct Rpimpv
    {
        /// <summary>
        ///  Length of Rpimpv in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Rpimpv
        /// </summary>
        public const int Factor = 100000000;
    }
}