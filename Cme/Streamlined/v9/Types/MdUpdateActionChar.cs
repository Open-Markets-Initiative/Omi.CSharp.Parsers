using using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Update Action Char: Indicates the type of Market Data update action
    /// </summary>

    public struct MdUpdateActionChar
    {
        /// <summary>
        ///  Fix Tag for Md Update Action Char
        /// </summary>
        public const ushort FixTag = 279;

        /// <summary>
        ///  Size of Md Update Action Char in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Md Update Action Char value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Md Update Action Char
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Md Update Action Char as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}