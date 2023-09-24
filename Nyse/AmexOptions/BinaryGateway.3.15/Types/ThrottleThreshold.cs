using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Throttle Threshold: Maximum number of inbound messages allowed over the time period specified by ThrottleWindow.
    /// </summary>

    public unsafe struct ThrottleThreshold
    {
        /// <summary>
        ///  Size of Throttle Threshold in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Throttle Threshold
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Throttle Threshold
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Throttle Threshold as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}