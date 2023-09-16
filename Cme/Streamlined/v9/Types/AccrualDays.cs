using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Accrual Days: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct AccrualDays
    {
        /// <summary>
        ///  Length of Accrual Days in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Accrual Days
        /// </summary>
        public const uint NoValue = 4294967295;
    }
}