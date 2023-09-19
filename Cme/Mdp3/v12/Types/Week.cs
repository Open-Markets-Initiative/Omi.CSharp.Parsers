using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Week: One Byte Fixed Width Integer
    /// </summary>

    public struct Week
    {
        /// <summary>
        ///  Length of Week in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Week
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Week
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Week as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}