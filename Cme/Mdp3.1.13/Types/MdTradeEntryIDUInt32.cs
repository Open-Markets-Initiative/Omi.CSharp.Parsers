using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Md Trade Entry I D u Int 32: Market Data Trade Entry ID
    /// </summary>

    public unsafe struct MdTradeEntryIDUInt32
    {
        /// <summary>
        ///  Fix Tag for Md Trade Entry I D u Int 32
        /// </summary>
        public const ushort FixTag = 37711;

        /// <summary>
        ///  Length of Md Trade Entry I D u Int 32 in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Md Trade Entry I D u Int 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Md Trade Entry I D u Int 32
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