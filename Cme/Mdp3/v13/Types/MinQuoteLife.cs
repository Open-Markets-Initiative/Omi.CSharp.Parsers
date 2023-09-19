using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Min Quote Life: Minimum Quote Life in number of microseconds
    /// </summary>

    public unsafe struct MinQuoteLife
    {
        /// <summary>
        ///  Fix Tag for Min Quote Life
        /// </summary>
        public const ushort FixTag = 37731;

        /// <summary>
        ///  Size of Min Quote Life in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Min Quote Life
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Min Quote Life
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Min Quote Life as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}