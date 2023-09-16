using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Maturity Date:
    /// </summary>

    public unsafe struct MaturityDate
    {
        /// <summary>
        ///  Length of Maturity Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}