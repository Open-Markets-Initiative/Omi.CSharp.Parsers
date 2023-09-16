using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Order Priority Optional: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public struct MdOrderPriorityOptional
    {
        /// <summary>
        ///  Length of Md Order Priority Optional in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Md Order Priority Optional
        /// </summary>
        public const ulong NoValue = 18446744073709551615;
    }
}