using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Price Level Optional: One Byte Fixed Width Integer
    /// </summary>

    public struct MdPriceLevelOptional
    {
        /// <summary>
        ///  Fix Tag for Md Price Level Optional
        /// </summary>
        public const ushort FixTag = 1023;

        /// <summary>
        ///  Length of Md Price Level Optional in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Md Price Level Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Md Price Level Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Md Price Level Optional as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}