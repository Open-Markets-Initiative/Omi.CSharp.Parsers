using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Price Display Format: Number of decimals in fractional display price
    /// </summary>

    public struct PriceDisplayFormat
    {
        /// <summary>
        ///  Fix Tag for Price Display Format
        /// </summary>
        public const ushort FixTag = 9800;

        /// <summary>
        ///  Length of Price Display Format in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Price Display Format
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Price Display Format
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Price Display Format as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}