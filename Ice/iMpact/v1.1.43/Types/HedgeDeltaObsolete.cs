using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Delta Obsolete: Hedge Delta Obsolete
    /// </summary>

    public unsafe struct HedgeDeltaObsolete
    {
        /// <summary>
        ///  Length of Hedge Delta Obsolete in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Hedge Delta Obsolete
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Hedge Delta Obsolete
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Value;
    }
}