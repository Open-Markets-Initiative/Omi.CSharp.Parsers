using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Gbp Price: Obsolete. The price will be published via the Fixing Indicative Price Message.
    /// </summary>

    public unsafe struct GbpPrice
    {
        /// <summary>
        ///  Length of Gbp Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Gbp Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Gbp Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Value;
    }
}