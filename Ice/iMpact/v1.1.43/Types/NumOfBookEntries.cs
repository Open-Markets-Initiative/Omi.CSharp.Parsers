using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Of Book Entries: Number of book entries in the market. It is the number of order messages followed for full order depth snapshot channel. In case of price level snapshot, it is the number of price level messages that followed for the market.
    /// </summary>

    public unsafe struct NumOfBookEntries
    {
        /// <summary>
        ///  Length of Num Of Book Entries in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Num Of Book Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Num Of Book Entries
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