using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Match Number: Execution Id. Identifies the component of an execution. Unique for a given day.  The match number is also referenced in the Trade Break Message.
    /// </summary>

    public unsafe struct MatchNumber
    {
        /// <summary>
        ///  Length of Match Number in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Match Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Match Number
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