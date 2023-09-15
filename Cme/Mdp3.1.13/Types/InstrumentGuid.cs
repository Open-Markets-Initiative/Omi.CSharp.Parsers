namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Instrument Guid: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public struct InstrumentGuid
    {
        /// <summary>
        ///  Length of Instrument Guid in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Instrument Guid
        /// </summary>
        public const ulong NoValue = 18446744073709551615;
    }
}