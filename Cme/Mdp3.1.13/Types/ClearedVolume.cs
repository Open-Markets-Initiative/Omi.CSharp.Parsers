namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Cleared Volume: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct ClearedVolume
    {
        /// <summary>
        ///  Length of Cleared Volume in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Cleared Volume
        /// </summary>
        public const int NoValue = 2147483647;
    }
}