using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
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