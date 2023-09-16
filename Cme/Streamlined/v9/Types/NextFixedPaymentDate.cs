using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Next Fixed Payment Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct NextFixedPaymentDate
    {
        /// <summary>
        ///  Length of Next Fixed Payment Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Next Fixed Payment Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}