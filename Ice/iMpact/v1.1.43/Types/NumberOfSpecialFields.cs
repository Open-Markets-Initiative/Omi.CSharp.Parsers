using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Number Of Special Fields: One Byte Fixed Width Integer
    /// </summary>

    public struct NumberOfSpecialFields
    {
        /// <summary>
        ///  Length of Number Of Special Fields in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Number Of Special Fields
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Number Of Special Fields
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Number Of Special Fields as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}