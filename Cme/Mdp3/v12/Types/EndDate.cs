using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  End Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct EndDate
    {
        /// <summary>
        ///  Length of End Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for End Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}