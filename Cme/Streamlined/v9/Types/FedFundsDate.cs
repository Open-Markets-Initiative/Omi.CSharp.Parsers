using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Fed Funds Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct FedFundsDate
    {
        /// <summary>
        ///  Length of Fed Funds Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Fed Funds Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}