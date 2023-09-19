using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Body Length: One Byte Fixed Width Integer
    /// </summary>

    public struct LegBodyLength
    {
        /// <summary>
        ///  Length of Leg Body Length in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Leg Body Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Leg Body Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

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