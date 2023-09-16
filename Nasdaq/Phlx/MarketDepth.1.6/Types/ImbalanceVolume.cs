using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Imbalance Volume: The imbalance contracts.
    /// </summary>

    public unsafe struct ImbalanceVolume
    {
        /// <summary>
        ///  Length of Imbalance Volume in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Imbalance Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Imbalance Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}