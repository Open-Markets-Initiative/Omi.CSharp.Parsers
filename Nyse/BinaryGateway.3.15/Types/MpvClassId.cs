using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Mpv Class Id: Identification number assigned to the MPVClass
    /// </summary>

    public unsafe struct MpvClassId
    {
        /// <summary>
        ///  Length of Mpv Class Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Mpv Class Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Mpv Class Id
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