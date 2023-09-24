using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Trd Reg Ts Prev Time Priority
    /// </summary>

    public unsafe struct TrdRegTsPrevTimePriority
    {
        /// <summary>
        ///  Size of Trd Reg Ts Prev Time Priority in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Trd Reg Ts Prev Time Priority value
        /// </summary>
        public readonly DateTime Value
            => Decode(this);

        /// <summary>
        ///  Read Trd Reg Ts Prev Time Priority
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Decode(TrdRegTsPrevTimePriority value)
            => DateTime.UnixEpoch.AddTicks((long)value.Bytes / TimeSpan.NanosecondsPerTick);

        /// <summary>
        ///  Write Trd Reg Ts Prev Time Priority
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(DateTime value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value.Ticks * TimeSpan.NanosecondsPerTick; }
        }

        /// <summary>
        ///  Trd Reg Ts Prev Time Priority as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}