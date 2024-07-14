using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  End Year: 4 digit year
    /// </summary>

    public struct EndYear
    {
        /// <summary>
        ///  Size of End Year in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  End Year value
        /// </summary>
        public readonly short Value
            => Decode();

        /// <summary>
        ///  Read End Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly short Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write End Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  End Year as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Underlying;
    }
}