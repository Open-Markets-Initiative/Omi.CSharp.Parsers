using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Throttle Threshold: Maximum number of inbound messages allowed over the time period specified by ThrottleWindow.
    /// </summary>

    public unsafe struct ThrottleThreshold
    {
        /// <summary>
        ///  Length of Throttle Threshold in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Throttle Threshold
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Throttle Threshold
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}