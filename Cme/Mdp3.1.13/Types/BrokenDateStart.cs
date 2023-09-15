namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Broken Date Start: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct BrokenDateStart
    {
        /// <summary>
        ///  Length of Broken Date Start in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Broken Date Start
        /// </summary>
        public const ushort NoValue = 65535;
    }
}