using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Next Floating Payment Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct NextFloatingPaymentDate
    {
        /// <summary>
        ///  Length of Next Floating Payment Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Next Floating Payment Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}