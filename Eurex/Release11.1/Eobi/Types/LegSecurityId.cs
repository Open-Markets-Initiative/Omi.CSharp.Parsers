using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Security Id
    /// </summary>

    public struct LegSecurityId
    {
        /// <summary>
        ///  Size of Leg Security Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Leg Security Id value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying;

        /// <summary>
        ///  Write Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value;

        /// <summary>
        ///  Leg Security Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}