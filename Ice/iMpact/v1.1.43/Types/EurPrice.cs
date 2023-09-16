using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Eur Price: Obsolete. The price will be published via the Fixing Indicative Price Message.
    /// </summary>

    public unsafe struct EurPrice
    {
        /// <summary>
        ///  Length of Eur Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Eur Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Eur Price
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