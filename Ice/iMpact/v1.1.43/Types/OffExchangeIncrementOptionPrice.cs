using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Off Exchange Increment Option Price: Off exchange options increment price. NumDecimalsOptionsPrice should be applied to this field
    /// </summary>

    public struct OffExchangeIncrementOptionPrice
    {
        /// <summary>
        ///  Size of Off Exchange Increment Option Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Off Exchange Increment Option Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Off Exchange Increment Option Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Off Exchange Increment Option Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Off Exchange Increment Option Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Off Exchange Increment Option Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}