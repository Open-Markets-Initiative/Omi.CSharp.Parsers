using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Order Priority: Order priority for execution on the order book
    /// </summary>

    public unsafe struct MdOrderPriority
    {
        /// <summary>
        ///  Fix Tag for Md Order Priority
        /// </summary>
        public const ushort FixTag = 37707;

        /// <summary>
        ///  Length of Md Order Priority in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Md Order Priority
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Md Order Priority
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Value;
    }
}