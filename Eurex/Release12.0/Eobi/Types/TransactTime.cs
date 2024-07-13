using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Transact Time
    /// </summary>

    public struct TransactTime
    {
        /// <summary>
        ///  Maximum value for Transact Time
        /// </summary>
        public const ulong Maximum = 18446744073709551614;

        /// <summary>
        ///  Minimum value for Transact Time
        /// </summary>
        public const ulong Minimum = 0;

        /// <summary>
        ///  Size of Transact Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Transact Time value
        /// </summary>
        public readonly DateTime Value
            => Decode();

        /// <summary>
        ///  Read Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly DateTime Decode()
            => DateTime.UnixEpoch.AddTicks(Underlying / TimeSpan.NanosecondsPerTick);

        /// <summary>
        ///  Write Transact Time as Nanoseconds since Jan 1st, 1970, 00:00:00 GMT
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(DateTime timestamp)
            => Underlying = timestamp.Ticks * TimeSpan.NanosecondsPerTick;

        /// <summary>
        ///  Transact Time as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}