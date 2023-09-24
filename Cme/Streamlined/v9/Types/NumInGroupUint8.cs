using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Num In Group uint 8
    /// </summary>

    public struct NumInGroupUint8
    {
        /// <summary>
        ///  Length of Num In Group uint 8 in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Num In Group uint 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Num In Group uint 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Num In Group uint 8 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}