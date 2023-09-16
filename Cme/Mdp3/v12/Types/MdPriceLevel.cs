using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Price Level: One Byte Fixed Width Integer
    /// </summary>

    public struct MdPriceLevel
    {
        /// <summary>
        ///  Fix Tag for Md Price Level
        /// </summary>
        public const ushort FixTag = 1023;

        /// <summary>
        ///  Length of Md Price Level in bytes
        /// </summary>
        public const int Length = 1;
    }
}