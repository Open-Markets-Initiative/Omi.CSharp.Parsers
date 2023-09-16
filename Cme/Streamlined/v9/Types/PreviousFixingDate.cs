using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Previous Fixing Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct PreviousFixingDate
    {
        /// <summary>
        ///  Length of Previous Fixing Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Previous Fixing Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}