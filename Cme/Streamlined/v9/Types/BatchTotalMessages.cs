using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Batch Total Messages: Total number of messages contained within batch which is defined by match event indicator (5799)
    /// </summary>

    public unsafe struct BatchTotalMessages
    {
        /// <summary>
        ///  Fix Tag for Batch Total Messages
        /// </summary>
        public const ushort FixTag = 50001;

        /// <summary>
        ///  Size of Batch Total Messages in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Batch Total Messages
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Batch Total Messages
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Batch Total Messages as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}