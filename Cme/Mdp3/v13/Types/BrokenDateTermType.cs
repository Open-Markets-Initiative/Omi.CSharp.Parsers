using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Broken Date Term Type: One Byte Fixed Width Integer
    /// </summary>

    public struct BrokenDateTermType
    {
        /// <summary>
        ///  Fix Tag for Broken Date Term Type
        /// </summary>
        public const ushort FixTag = 6651;

        /// <summary>
        ///  Length of Broken Date Term Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Broken Date Term Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Broken Date Term Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Broken Date Term Type as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}