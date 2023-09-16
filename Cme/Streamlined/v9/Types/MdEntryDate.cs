using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Date: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct MdEntryDate
    {
        /// <summary>
        ///  Length of Md Entry Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Md Entry Date
        /// </summary>
        public const int NoValue = 2147483647;
    }
}