using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Price Level Optional: Aggregate book position
    /// </summary>

    public struct MdPriceLevelOptional
    {
        /// <summary>
        ///  Fix Tag for Md Price Level Optional
        /// </summary>
        public const ushort FixTag = 1023;

        /// <summary>
        ///  Sentinel null value for Md Price Level Optional
        /// </summary>
        public const sbyte NoValue = 127;

        /// <summary>
        ///  Size of Md Price Level Optional in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Md Price Level Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Md Price Level Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Md Price Level Optional as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}