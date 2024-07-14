using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Open Interest
    /// </summary>

    public struct OpenInterest
    {
        /// <summary>
        ///  Size of Open Interest in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Open Interest value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Open Interest
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Open Interest
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Open Interest as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}