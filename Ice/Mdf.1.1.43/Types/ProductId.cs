using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Product Id: ID of the product that the contract/market is under.
    /// </summary>

    public unsafe struct ProductId
    {
        /// <summary>
        ///  Length of Product Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Product Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Product Id
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