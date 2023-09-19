using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Body Len
    /// </summary>

    public unsafe struct BodyLen
    {
        /// <summary>
        ///  Size of Body Len in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Body Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Body Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Body Len as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}