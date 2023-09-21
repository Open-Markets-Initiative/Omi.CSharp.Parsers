using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  No Related Sym
    /// </summary>

    public struct NoRelatedSym
    {
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
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}