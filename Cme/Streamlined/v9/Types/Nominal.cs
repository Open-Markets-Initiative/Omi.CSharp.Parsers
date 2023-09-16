using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Nominal: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public struct Nominal
    {
        /// <summary>
        ///  Length of Nominal in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Nominal
        /// </summary>
        public const ulong NoValue = 18446744073709551615;
    }
}