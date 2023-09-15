namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Trading Reference Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct TradingReferenceDate
    {
        /// <summary>
        ///  Length of Trading Reference Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Trading Reference Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}