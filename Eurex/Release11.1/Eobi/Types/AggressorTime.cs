using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Aggressor Time
    /// </summary>

    public struct AggressorTime
    {
        /// <summary>
        ///  Size of Aggressor Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Aggressor Time value
        /// </summary>
        public readonly DateTime Value
            => Decode();

        /// <summary>
        ///  Read Aggressor Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly DateTime Decode()
            => DateTime.UnixEpoch.AddTicks(Underlying / TimeSpan.NanosecondsPerTick);

        /// <summary>
        ///  Write Aggressor Time as Nanoseconds since Jan 1st, 1970, 00:00:00 GMT
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(DateTime timestamp)
            => Underlying = timestamp.Ticks * TimeSpan.NanosecondsPerTick;

        /// <summary>
        ///  Aggressor Time as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}