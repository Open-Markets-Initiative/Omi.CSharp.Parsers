using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Opt Attribute:
    /// </summary>

    public unsafe struct OptAttribute
    {
        /// <summary>
        ///  Length of Opt Attribute in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Opt Attribute
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Opt Attribute
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