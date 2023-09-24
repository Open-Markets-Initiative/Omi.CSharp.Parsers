using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Request Trading Engine Received Timestamp: This field can be used to get the time the trading engine received the request that triggers this message
    /// </summary>

    public unsafe struct RequestTradingEngineReceivedTimestamp
    {
        /// <summary>
        ///  Length of Request Trading Engine Received Timestamp in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Request Trading Engine Received Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((long)pointer); }
        }

        /// <summary>
        ///  Write Request Trading Engine Received Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Request Trading Engine Received Timestamp as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}