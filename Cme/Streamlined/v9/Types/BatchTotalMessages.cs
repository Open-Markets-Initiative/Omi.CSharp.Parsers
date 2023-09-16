using System.Runtime.CompilerServices;;

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
        ///  Length of Batch Total Messages in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Batch Total Messages
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Batch Total Messages
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}