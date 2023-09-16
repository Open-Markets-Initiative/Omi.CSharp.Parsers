using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Trd Reg Ts Prev Time Priority:
    /// </summary>

    public unsafe struct TrdRegTsPrevTimePriority
    {
        /// <summary>
        ///  Length of Trd Reg Ts Prev Time Priority in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Trd Reg Ts Prev Time Priority
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Trd Reg Ts Prev Time Priority
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