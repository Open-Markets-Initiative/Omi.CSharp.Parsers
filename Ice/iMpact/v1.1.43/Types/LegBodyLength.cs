using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Body Length: Message length, including this field, for a leg
    /// </summary>

    public struct LegBodyLength
    {
        /// <summary>
        ///  Size of Leg Body Length in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Leg Body Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Leg Body Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Leg Body Length as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}