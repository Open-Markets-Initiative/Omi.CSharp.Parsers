using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Security Id: Security ID
    /// </summary>

    public unsafe struct SecurityId
    {
        /// <summary>
        ///  Fix Tag for Security Id
        /// </summary>
        public const ushort FixTag = 48;

        /// <summary>
        ///  Length of Security Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Security Id
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