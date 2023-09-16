using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Mantissa: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public struct Mantissa
    {
        /// <summary>
        ///  Length of Mantissa in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Mantissa
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}