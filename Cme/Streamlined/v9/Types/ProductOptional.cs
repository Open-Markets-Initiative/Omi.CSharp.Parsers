using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Product Optional: One Byte Fixed Width Integer
    /// </summary>

    public struct ProductOptional
    {
        /// <summary>
        ///  Fix Tag for Product Optional
        /// </summary>
        public const ushort FixTag = 460;

        /// <summary>
        ///  Length of Product Optional in bytes
        /// </summary>
        public const int Length = 1;
    }
}