using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Packet Id: Packet Identifier
    /// </summary>

    public unsafe struct PacketId
    {
        /// <summary>
        ///  Length of Packet Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Packet Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Packet Id
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