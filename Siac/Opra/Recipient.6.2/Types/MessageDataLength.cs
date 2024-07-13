using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Message Data Length: Represents The Length Of The Message Data Field
    /// </summary>

    public struct MessageDataLength
    {
        /// <summary>
        ///  Size of Message Data Length in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Message Data Length value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Message Data Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Message Data Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Message Data Length to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Message Data Length as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}