using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Index Value: Contains The Index Value Using Last Sale Values Of Index Components
    /// </summary>

    public struct IndexValue
    {
        /// <summary>
        ///  Size of Index Value in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Index Value value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Index Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Index Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Index Value as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}