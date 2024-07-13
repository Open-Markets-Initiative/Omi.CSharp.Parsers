using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Underlying Product Optional: Product complex
    /// </summary>

    public struct UnderlyingProductOptional
    {
        /// <summary>
        ///  Fix Tag for Underlying Product Optional
        /// </summary>
        public const ushort FixTag = 462;

        /// <summary>
        ///  Sentinel null value for Underlying Product Optional
        /// </summary>
        public const byte NoValue = 255;

        /// <summary>
        ///  Length of Underlying Product Optional in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Underlying Product Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Underlying Product Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Underlying Product Optional as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}