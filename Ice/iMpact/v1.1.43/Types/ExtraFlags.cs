using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Extra Flags: One Byte Fixed Width Integer
    /// </summary>

    public struct ExtraFlags
    {
        /// <summary>
        ///  Length of Extra Flags in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Extra Flags
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Extra Flags
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Extra Flags as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}