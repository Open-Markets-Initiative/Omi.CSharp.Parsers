using System.Runtime.CompilerServices;

namespace Iex.Tops
{
    /// <summary>
    ///  Timestamp: Time stamp of the system event
    /// </summary>

    public struct Timestamp
    {
        /// <summary>
        ///  Size of Timestamp in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Timestamp value
        /// </summary>
        public readonly DateTime Value
            => Decode();

        /// <summary>
        ///  Read Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly DateTime Decode()
            => DateTime.UnixEpoch.AddTicks(Underlying / TimeSpan.NanosecondsPerTick);

        /// <summary>
        ///  Write Timestamp as Nanoseconds since Jan 1st, 1970, 00:00:00 GMT
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(DateTime timestamp)
            => Underlying = timestamp.Ticks * TimeSpan.NanosecondsPerTick;

        /// <summary>
        ///  Timestamp as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}