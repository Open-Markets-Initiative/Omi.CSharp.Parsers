using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Throttle Threshold: Maximum number of inbound messages allowed over the time period specified by ThrottleWindow.
    /// </summary>

    public struct ThrottleThreshold
    {
        /// <summary>
        ///  Size of Throttle Threshold in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Throttle Threshold value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Throttle Threshold
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Throttle Threshold
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Throttle Threshold as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}