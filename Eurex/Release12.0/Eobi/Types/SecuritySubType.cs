using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Security Sub Type:
    /// </summary>

    public unsafe struct SecuritySubType
    {
        /// <summary>
        ///  Length of Security Sub Type in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}