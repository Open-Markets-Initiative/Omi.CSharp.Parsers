using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Related Security Id:
    /// </summary>

    public unsafe struct RelatedSecurityId
    {
        /// <summary>
        ///  Length of Related Security Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Related Security Id
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