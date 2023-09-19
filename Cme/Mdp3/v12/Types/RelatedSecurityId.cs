using System.Runtime.CompilerServices;

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
        ///  Size of Related Security Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Related Security Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}