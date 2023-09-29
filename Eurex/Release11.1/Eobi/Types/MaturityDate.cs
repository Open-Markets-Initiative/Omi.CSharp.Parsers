using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Maturity Date
    /// </summary>

    public struct MaturityDate
    {
        /// <summary>
        ///  Size of Maturity Date in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Maturity Date value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Maturity Date as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}