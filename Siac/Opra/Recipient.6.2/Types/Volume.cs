using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Volume: Represents The Total Number Of Contracts Traded For An Option In One Trade Or The Total Number Of Contracts Traded For An Option For The Entire Trading Day
    /// </summary>

    public struct Volume
    {
        /// <summary>
        ///  Size of Volume in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Volume value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Volume as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}