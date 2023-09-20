using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Last Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct LastPx
    {
        /// <summary>
        ///  Length of Last Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Last Px
        /// </summary>
        public const int Factor = 100000000;
    }
}