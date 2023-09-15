namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Dated Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct DatedDate
    {
        /// <summary>
        ///  Length of Dated Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Dated Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}