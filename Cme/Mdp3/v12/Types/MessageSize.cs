using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Message Size: Message Size
    /// </summary>

    public unsafe struct MessageSize
    {
        /// <summary>
        ///  Length of Message Size in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Message Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Message Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}