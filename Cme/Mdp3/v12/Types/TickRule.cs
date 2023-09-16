using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Tick Rule: One Byte Fixed Width Integer
    /// </summary>

    public struct TickRule
    {
        /// <summary>
        ///  Fix Tag for Tick Rule
        /// </summary>
        public const ushort FixTag = 6350;

        /// <summary>
        ///  Length of Tick Rule in bytes
        /// </summary>
        public const int Length = 1;
    }
}