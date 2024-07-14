using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Screen Last Trade Year: Screen last trade year, 4 digits
    /// </summary>

    public struct ScreenLastTradeYear
    {
        /// <summary>
        ///  Size of Screen Last Trade Year in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Screen Last Trade Year value
        /// </summary>
        public readonly short Value
            => Decode();

        /// <summary>
        ///  Read Screen Last Trade Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly short Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Screen Last Trade Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Screen Last Trade Year as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Underlying;
    }
}