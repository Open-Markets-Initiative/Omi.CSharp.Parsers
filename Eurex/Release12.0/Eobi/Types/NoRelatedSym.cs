using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  No Related Sym
    /// </summary>

    public struct NoRelatedSym
    {
        /// <summary>
        ///  Sentinel null value for No Related Sym
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Maximum value for No Related Sym
        /// </summary>
        public const byte Maximum = 24;

        /// <summary>
        ///  Minimum value for No Related Sym
        /// </summary>
        public const byte Minimum = 0;

        /// <summary>
        ///  Fix Tag for No Related Sym
        /// </summary>
        public const ushort FixTag = 146;

        /// <summary>
        ///  Length of No Related Sym in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read No Related Sym
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write No Related Sym
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  No Related Sym as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}