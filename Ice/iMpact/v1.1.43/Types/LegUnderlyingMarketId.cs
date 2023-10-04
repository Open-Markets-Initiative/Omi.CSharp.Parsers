using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Underlying Market Id: Futures market id of the underlying futures market
    /// </summary>

    public struct LegUnderlyingMarketId
    {
        /// <summary>
        ///  Size of Leg Underlying Market Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Leg Underlying Market Id value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Leg Underlying Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Leg Underlying Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Leg Underlying Market Id to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Leg Underlying Market Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}