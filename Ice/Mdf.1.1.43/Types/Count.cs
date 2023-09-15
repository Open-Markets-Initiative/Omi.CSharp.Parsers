using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Count: Field indicates the number of messages contained in the block.
    /// </summary>

    public unsafe struct Count
    {
        /// <summary>
        ///  Length of Count in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Count
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