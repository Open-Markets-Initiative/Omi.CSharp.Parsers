using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Lot Type: One Byte Fixed Width Integer
    /// </summary>

    public struct LotType
    {
        /// <summary>
        ///  Fix Tag for Lot Type
        /// </summary>
        public const ushort FixTag = 1093;

        /// <summary>
        ///  Length of Lot Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}