using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Of Cycles: Numeric Number of cycles for a contract
    /// </summary>

    public struct NumOfCycles
    {
        /// <summary>
        ///  Size of Num Of Cycles in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Num Of Cycles value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Num Of Cycles
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Num Of Cycles
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Num Of Cycles as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}