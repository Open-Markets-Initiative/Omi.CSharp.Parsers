using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Price
    /// </summary>

    public unsafe struct LegPrice
    {
        /// <summary>
        ///  Decimal place factor for Leg Price
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Leg Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Leg Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Leg Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Leg Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}