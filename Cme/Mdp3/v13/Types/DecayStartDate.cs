using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Decay Start Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct DecayStartDate
    {
        /// <summary>
        ///  Length of Decay Start Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Decay Start Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}