namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Broken Date End: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct BrokenDateEnd
    {
        /// <summary>
        ///  Length of Broken Date End in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Broken Date End
        /// </summary>
        public const ushort NoValue = 65535;
    }
}