using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Batch Total Messages Optional: Total number of messages contained within batch which is defined by match event indicator (5799)
    /// </summary>

    public unsafe struct BatchTotalMessagesOptional
    {
        /// <summary>
        ///  Fix Tag for Batch Total Messages Optional
        /// </summary>
        public const ushort FixTag = 50001;

        /// <summary>
        ///  Length of Batch Total Messages Optional in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Batch Total Messages Optional
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Batch Total Messages Optional in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Batch Total Messages Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Try Read Batch Total Messages Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Batch Total Messages Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Set Batch Total Messages Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Batch Total Messages Optional as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}