using using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Type: Indicates the type of Market Data entry
    /// </summary>

    public struct MdEntryType
    {
        /// <summary>
        ///  Fix Tag for Md Entry Type
        /// </summary>
        public const ushort FixTag = 269;

        /// <summary>
        ///  Size of Md Entry Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Md Entry Type value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Md Entry Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Md Entry Type as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}