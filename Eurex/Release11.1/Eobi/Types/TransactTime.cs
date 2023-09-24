using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Transact Time
    /// </summary>

    public unsafe struct TransactTime
    {
        /// <summary>
        ///  Size of Transact Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Transact Time value
        /// </summary>
        public readonly DateTime Value
            => Decode(this);

        /// <summary>
        ///  Read Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Decode(TransactTime value)
            => DateTime.UnixEpoch.AddTicks((long)value.Bytes / TimeSpan.NanosecondsPerTick);

        /// <summary>
        ///  Write Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(DateTime value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value.Ticks * TimeSpan.NanosecondsPerTick; }
        }

        /// <summary>
        ///  Transact Time as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}