using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Trd Reg Ts Execution Time
    /// </summary>

    public unsafe struct TrdRegTsExecutionTime
    {
        /// <summary>
        ///  Size of Trd Reg Ts Execution Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Trd Reg Ts Execution Time value
        /// </summary>
        public readonly DateTime Value
            => Decode(this);

        /// <summary>
        ///  Read Trd Reg Ts Execution Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Decode(TrdRegTsExecutionTime value)
            => DateTime.UnixEpoch.AddTicks((long)value.Bytes / TimeSpan.NanosecondsPerTick);

        /// <summary>
        ///  Write Trd Reg Ts Execution Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(DateTime value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value.Ticks * TimeSpan.NanosecondsPerTick; }
        }

        /// <summary>
        ///  Trd Reg Ts Execution Time as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}