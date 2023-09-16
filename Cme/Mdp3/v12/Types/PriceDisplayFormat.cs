using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Price Display Format: One Byte Fixed Width Integer
    /// </summary>

    public struct PriceDisplayFormat
    {
        /// <summary>
        ///  Fix Tag for Price Display Format
        /// </summary>
        public const ushort FixTag = 9800;

        /// <summary>
        ///  Length of Price Display Format in bytes
        /// </summary>
        public const int Length = 1;
    }
}