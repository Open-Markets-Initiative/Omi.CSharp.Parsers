using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Related Security Id
    /// </summary>

    public struct RelatedSecurityId
    {
        /// <summary>
        ///  Maximum value for Related Security Id
        /// </summary>
        public const long Maximum = 9223372036854775807;

        /// <summary>
        ///  Minimum value for Related Security Id
        /// </summary>
        public const long Minimum = -9223372036854775807;

        /// <summary>
        ///  Size of Related Security Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Related Security Id value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying;

        /// <summary>
        ///  Write Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value;

        /// <summary>
        ///  Related Security Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}