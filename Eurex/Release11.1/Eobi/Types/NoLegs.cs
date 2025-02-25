using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  No Legs
    /// </summary>

    public struct NoLegs
    {
        /// <summary>
        ///  Sentinel null value for No Legs
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Maximum value for No Legs
        /// </summary>
        public const byte Maximum = 20;

        /// <summary>
        ///  Minimum value for No Legs
        /// </summary>
        public const byte Minimum = 2;

        /// <summary>
        ///  Fix Tag for No Legs
        /// </summary>
        public const ushort FixTag = 555;

        /// <summary>
        ///  Length of No Legs in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read No Legs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write No Legs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  No Legs as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}