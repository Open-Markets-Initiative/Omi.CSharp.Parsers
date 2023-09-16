using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Put Or Call: One Byte Fixed Width Integer
    /// </summary>

    public struct PutOrCall
    {
        /// <summary>
        ///  Fix Tag for Put Or Call
        /// </summary>
        public const ushort FixTag = 201;

        /// <summary>
        ///  Length of Put Or Call in bytes
        /// </summary>
        public const int Length = 1;
    }
}