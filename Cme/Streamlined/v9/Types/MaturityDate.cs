using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Maturity Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct MaturityDate
    {
        /// <summary>
        ///  Length of Maturity Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Maturity Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}