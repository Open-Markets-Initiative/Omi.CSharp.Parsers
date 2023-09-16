using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Size Optional: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct MdEntrySizeOptional
    {
        /// <summary>
        ///  Length of Md Entry Size Optional in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Md Entry Size Optional
        /// </summary>
        public const int NoValue = 2147483647;
    }
}