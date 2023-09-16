using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Trade Transaction Id: The value used to associate bundles of the same transaction. This value will be 0 when the transaction has no trade. The value will be -1 if the channel does not support sub-bundling.
    /// </summary>

    public unsafe struct TradeTransactionId
    {
        /// <summary>
        ///  Length of Trade Transaction Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Trade Transaction Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Trade Transaction Id
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