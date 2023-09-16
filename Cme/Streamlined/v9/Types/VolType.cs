using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Vol Type: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct VolType
    {
        /// <summary>
        ///  Length of Vol Type in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Vol Type
        /// </summary>
        public const ushort NoValue = 65535;
    }
}