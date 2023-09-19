using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Body Length: One Byte Fixed Width Integer
    /// </summary>

    public struct HedgeBodyLength
    {
        /// <summary>
        ///  Length of Hedge Body Length in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Hedge Body Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Hedge Body Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

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