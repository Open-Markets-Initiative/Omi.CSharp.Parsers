using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Trd Reg Ts Execution Time:
    /// </summary>

    public unsafe struct TrdRegTsExecutionTime
    {
        /// <summary>
        ///  Length of Trd Reg Ts Execution Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Trd Reg Ts Execution Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Trd Reg Ts Execution Time
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