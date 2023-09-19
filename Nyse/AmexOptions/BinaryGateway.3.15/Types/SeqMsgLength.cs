using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Seq Msg Length: Length of sequenced data message including this field
    /// </summary>

    public unsafe struct SeqMsgLength
    {
        /// <summary>
        ///  Size of Seq Msg Length in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Seq Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Seq Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Seq Msg Length as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}