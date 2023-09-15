using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Throttle Window: Time period over which the ThrottleThreshold is enforced.
    /// </summary>

    public unsafe struct ThrottleWindow
    {
        /// <summary>
        ///  Length of Throttle Window in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Throttle Window
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Throttle Window
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