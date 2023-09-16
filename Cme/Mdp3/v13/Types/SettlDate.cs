using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Settl Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct SettlDate
    {
        /// <summary>
        ///  Length of Settl Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Settl Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}