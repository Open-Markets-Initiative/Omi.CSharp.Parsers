using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Price Type: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct PriceType
    {
        /// <summary>
        ///  Length of Price Type in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Price Type
        /// </summary>
        public const ushort NoValue = 65535;
    }
}