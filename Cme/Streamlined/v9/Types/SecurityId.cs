using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Security Id: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public struct SecurityId
    {
        /// <summary>
        ///  Length of Security Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Security Id
        /// </summary>
        public const ulong NoValue = 18446744073709551615;
    }
}