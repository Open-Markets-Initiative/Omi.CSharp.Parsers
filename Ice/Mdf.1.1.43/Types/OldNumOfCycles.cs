using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Old Num Of Cycles: Number of cycles for a contract.
    /// </summary>

    public unsafe struct OldNumOfCycles
    {
        /// <summary>
        ///  Length of Old Num Of Cycles in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Old Num Of Cycles
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Old Num Of Cycles
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Value;
    }
}