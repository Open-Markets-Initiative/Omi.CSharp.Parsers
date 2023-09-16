using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Main Fraction: One Byte Fixed Width Integer
    /// </summary>

    public struct MainFraction
    {
        /// <summary>
        ///  Fix Tag for Main Fraction
        /// </summary>
        public const ushort FixTag = 37702;

        /// <summary>
        ///  Length of Main Fraction in bytes
        /// </summary>
        public const int Length = 1;
    }
}