using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Open Close Settl Flag: One Byte Fixed Width Integer
    /// </summary>

    public struct OpenCloseSettlFlag
    {
        /// <summary>
        ///  Fix Tag for Open Close Settl Flag
        /// </summary>
        public const ushort FixTag = 286;

        /// <summary>
        ///  Length of Open Close Settl Flag in bytes
        /// </summary>
        public const int Length = 1;
    }
}