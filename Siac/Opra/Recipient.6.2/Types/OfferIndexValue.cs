using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Offer Index Value: The Offer Index Value Represents The Value Of The Indexs Calculation Formula Using The Current Offer Values Of The Component Securities
    /// </summary>

    public struct OfferIndexValue
    {
        /// <summary>
        ///  Size of Offer Index Value in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Offer Index Value value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Offer Index Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Offer Index Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Offer Index Value to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Offer Index Value as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}