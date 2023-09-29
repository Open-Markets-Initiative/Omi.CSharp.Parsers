using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Throttle Window: Time period over which the ThrottleThreshold is enforced.
    /// </summary>

    public struct ThrottleWindow
    {
        /// <summary>
        ///  Size of Throttle Window in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Throttle Window value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Throttle Window
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Throttle Window
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Throttle Window as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}