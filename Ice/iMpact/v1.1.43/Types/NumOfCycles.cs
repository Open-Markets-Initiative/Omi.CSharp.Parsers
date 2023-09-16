using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Of Cycles: Numeric Number of cycles for a contract
    /// </summary>

    public unsafe struct NumOfCycles
    {
        /// <summary>
        ///  Length of Num Of Cycles in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Num Of Cycles
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Num Of Cycles
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}