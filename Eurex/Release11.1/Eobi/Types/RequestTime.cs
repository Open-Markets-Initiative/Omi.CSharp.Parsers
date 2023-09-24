using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Request Time
    /// </summary>

    public unsafe struct RequestTime
    {
        /// <summary>
        ///  Size of Request Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Request Time value
        /// </summary>
        public readonly DateTime Value
            => Decode(this);

        /// <summary>
        ///  Read Request Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Decode(RequestTime value)
            => DateTime.UnixEpoch.AddTicks((long)value.Bytes / TimeSpan.NanosecondsPerTick);

        /// <summary>
        ///  Write Request Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(DateTime value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value.Ticks * TimeSpan.NanosecondsPerTick; }
        }

        /// <summary>
        ///  Request Time as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}