using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Size: Identifies The Number Of Contracts Being Bought For An Option At The Price
    /// </summary>

    public struct Size
    {
        /// <summary>
        ///  Size of Size in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Size value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Size to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}