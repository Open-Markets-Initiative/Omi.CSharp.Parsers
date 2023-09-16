using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Luldmpv: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct Luldmpv
    {
        /// <summary>
        ///  Length of Luldmpv in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Luldmpv
        /// </summary>
        public const int Factor = 100000000;
    }
}