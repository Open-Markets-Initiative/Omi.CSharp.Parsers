using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Msg Length: Total message length, including this header
    /// </summary>

    public unsafe struct MsgLength
    {
        /// <summary>
        ///  Size of Msg Length in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Msg Length as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}