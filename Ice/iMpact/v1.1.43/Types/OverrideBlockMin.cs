using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Override Block Min: Override Block Minimum
    /// </summary>

    public struct OverrideBlockMin
    {
        /// <summary>
        ///  Size of Override Block Min in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Override Block Min value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Override Block Min
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Override Block Min as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}