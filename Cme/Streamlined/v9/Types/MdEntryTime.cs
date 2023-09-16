using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Time: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct MdEntryTime
    {
        /// <summary>
        ///  Length of Md Entry Time in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Md Entry Time
        /// </summary>
        public const int NoValue = 2147483647;
    }
}