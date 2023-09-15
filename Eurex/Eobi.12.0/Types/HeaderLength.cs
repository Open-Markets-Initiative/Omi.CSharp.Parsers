using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Header Length: Packet header Length in Bytes
    /// </summary>

    public unsafe struct HeaderLength
    {
        /// <summary>
        ///  Length of Header Length in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Header Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Header Length
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