using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Mm Sent Time: Customer provided sending time. CAT compliance Number of nanoseconds since Epoch.
    /// </summary>

    public struct MmSentTime
    {
        /// <summary>
        ///  Size of Mm Sent Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Mm Sent Time value
        /// </summary>
        public readonly DateTime Value
            => Decode();

        /// <summary>
        ///  Read Mm Sent Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly DateTime Decode()
            => DateTime.UnixEpoch.AddTicks(Underlying / TimeSpan.NanosecondsPerTick);

        /// <summary>
        ///  Write Mm Sent Time as Nanoseconds since Jan 1st, 1970, 00:00:00 GMT
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(DateTime timestamp)
            => Underlying = timestamp.Ticks * TimeSpan.NanosecondsPerTick;

        /// <summary>
        ///  Mm Sent Time as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}