using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Legal Width Multiplier: Multiplier applied to standard legal width. For example:
    /// </summary>

    public struct LegalWidthMultiplier
    {
        /// <summary>
        ///  Length of Legal Width Multiplier in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Legal Width Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Legal Width Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Legal Width Multiplier as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}