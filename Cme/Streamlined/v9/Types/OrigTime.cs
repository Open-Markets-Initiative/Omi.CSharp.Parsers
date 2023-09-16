using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Orig Time: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public struct OrigTime
    {
        /// <summary>
        ///  Length of Orig Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Orig Time
        /// </summary>
        public const ulong NoValue = 18446744073709551615;
    }
}