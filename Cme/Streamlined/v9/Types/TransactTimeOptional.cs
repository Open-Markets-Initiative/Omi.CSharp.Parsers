using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Transact Time Optional: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public struct TransactTimeOptional
    {
        /// <summary>
        ///  Length of Transact Time Optional in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Transact Time Optional
        /// </summary>
        public const ulong NoValue = 18446744073709551615;
    }
}