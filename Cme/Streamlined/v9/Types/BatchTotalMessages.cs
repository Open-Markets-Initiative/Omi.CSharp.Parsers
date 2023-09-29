using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Batch Total Messages: Total number of messages contained within batch which is defined by match event indicator (5799)
    /// </summary>

    public struct BatchTotalMessages
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
        ///  Batch Total Messages value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Batch Total Messages
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Batch Total Messages
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Batch Total Messages as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}