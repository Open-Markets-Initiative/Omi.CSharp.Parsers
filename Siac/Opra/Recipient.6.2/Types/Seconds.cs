using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Seconds: Contains The Number Seconds From Epoch 111970000000 Utc
    /// </summary>

    public struct Seconds
    {
        /// <summary>
        ///  Size of Seconds in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Seconds value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Seconds
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Seconds
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Seconds to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Seconds as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}