using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hub Id: ID of the hub for the contract/market
    /// </summary>

    public unsafe struct HubId
    {
        /// <summary>
        ///  Length of Hub Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Hub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Hub Id
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