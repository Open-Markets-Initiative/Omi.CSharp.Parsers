using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Body Length: Message length, including this  field, for a hedge
    /// </summary>

    public struct HedgeBodyLength
    {
        /// <summary>
        ///  Size of Hedge Body Length in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Hedge Body Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Hedge Body Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Hedge Body Length as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}