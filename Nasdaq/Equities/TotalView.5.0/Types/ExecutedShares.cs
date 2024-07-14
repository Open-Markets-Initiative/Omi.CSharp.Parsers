using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Executed Shares: The number of shares executed.
    /// </summary>

    public struct ExecutedShares
    {
        /// <summary>
        ///  Size of Executed Shares in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Executed Shares value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Executed Shares
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Executed Shares
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Executed Shares as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}