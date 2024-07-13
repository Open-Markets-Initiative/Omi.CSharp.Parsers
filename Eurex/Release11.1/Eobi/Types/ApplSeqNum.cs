using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Appl Seq Num
    /// </summary>

    public struct ApplSeqNum
    {
        /// <summary>
        ///  Maximum value for Appl Seq Num
        /// </summary>
        public const uint Maximum = 4294967294;

        /// <summary>
        ///  Minimum value for Appl Seq Num
        /// </summary>
        public const uint Minimum = 0;

        /// <summary>
        ///  Size of Appl Seq Num in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Appl Seq Num value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Appl Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Appl Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Appl Seq Num as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}