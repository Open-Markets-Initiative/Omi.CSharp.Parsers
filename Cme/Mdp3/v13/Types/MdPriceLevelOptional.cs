using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Price Level Optional: One Byte Fixed Width Integer
    /// </summary>

    public struct MdPriceLevelOptional
    {
        /// <summary>
        ///  Fix Tag for Md Price Level Optional
        /// </summary>
        public const ushort FixTag = 1023;

        /// <summary>
        ///  Length of Md Price Level Optional in bytes
        /// </summary>
        public const int Length = 1;
    }
}