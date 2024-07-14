using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Options Expiration Year: 4 digit year
    /// </summary>

    public struct OptionsExpirationYear
    {
        /// <summary>
        ///  Size of Options Expiration Year in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Options Expiration Year value
        /// </summary>
        public readonly short Value
            => Decode();

        /// <summary>
        ///  Read Options Expiration Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly short Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Options Expiration Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Options Expiration Year as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Underlying;
    }
}