using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Market Depth: Book depth
    /// </summary>

    public struct MarketDepth
    {
        /// <summary>
        ///  Fix Tag for Market Depth
        /// </summary>
        public const ushort FixTag = 264;

        /// <summary>
        ///  Size of Market Depth in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Market Depth
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Market Depth
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Market Depth as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}