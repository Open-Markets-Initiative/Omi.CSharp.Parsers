using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Last Message Sequence Id: This should be used for synchronization with live update messages. Please see the main tech spec for details on how it can be done.
    /// </summary>

    public struct LastMessageSequenceId
    {
        /// <summary>
        ///  Size of Last Message Sequence Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Last Message Sequence Id value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Last Message Sequence Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Last Message Sequence Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Last Message Sequence Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}