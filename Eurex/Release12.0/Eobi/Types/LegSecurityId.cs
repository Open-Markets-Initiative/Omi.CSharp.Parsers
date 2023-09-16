using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Security Id:
    /// </summary>

    public unsafe struct LegSecurityId
    {
        /// <summary>
        ///  Length of Leg Security Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Value;
    }
}