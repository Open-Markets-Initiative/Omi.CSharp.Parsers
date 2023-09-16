using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Last Message Sequence Id: This should be used for synchronization with live update messages. Please see the main tech spec for details on how it can be done.
    /// </summary>

    public unsafe struct LastMessageSequenceId
    {
        /// <summary>
        ///  Length of Last Message Sequence Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Last Message Sequence Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Last Message Sequence Id
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