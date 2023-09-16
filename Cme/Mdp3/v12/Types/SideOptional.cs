using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Side Optional: One Byte Fixed Width Integer
    /// </summary>

    public struct SideOptional
    {
        /// <summary>
        ///  Fix Tag for Side Optional
        /// </summary>
        public const ushort FixTag = 54;

        /// <summary>
        ///  Length of Side Optional in bytes
        /// </summary>
        public const int Length = 1;
    }
}