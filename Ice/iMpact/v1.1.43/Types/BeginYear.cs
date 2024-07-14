using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Begin Year: 4 digit year
    /// </summary>

    public struct BeginYear
    {
        /// <summary>
        ///  Size of Begin Year in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Begin Year value
        /// </summary>
        public readonly short Value
            => Decode();

        /// <summary>
        ///  Read Begin Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly short Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Begin Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Begin Year as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Underlying;
    }
}