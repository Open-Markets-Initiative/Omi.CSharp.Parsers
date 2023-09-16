using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Off Exchange Increment Option Price: Off exchange options increment price. NumDecimalsOptionsPrice should be applied to this field
    /// </summary>

    public unsafe struct OffExchangeIncrementOptionPrice
    {
        /// <summary>
        ///  Length of Off Exchange Increment Option Price in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Off Exchange Increment Option Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Off Exchange Increment Option Price
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