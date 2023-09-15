using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Seq Msg Length: Length of sequenced data message including this field
    /// </summary>

    public unsafe struct SeqMsgLength
    {
        /// <summary>
        ///  Length of Seq Msg Length in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Seq Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Seq Msg Length
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