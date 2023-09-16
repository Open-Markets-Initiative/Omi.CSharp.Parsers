using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Appl Id: The channel ID as defined in the XML Configuration file
    /// </summary>

    public unsafe struct ApplId
    {
        /// <summary>
        ///  Fix Tag for Appl Id
        /// </summary>
        public const ushort FixTag = 1180;

        /// <summary>
        ///  Length of Appl Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Value;
    }
}