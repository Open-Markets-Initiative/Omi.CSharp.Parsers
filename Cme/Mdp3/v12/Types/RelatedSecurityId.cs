using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Related Security Id: Related Security ID
    /// </summary>

    public unsafe struct RelatedSecurityId
    {
        /// <summary>
        ///  Fix Tag for Related Security Id
        /// </summary>
        public const ushort FixTag = 1650;

        /// <summary>
        ///  Length of Related Security Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Related Security Id
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