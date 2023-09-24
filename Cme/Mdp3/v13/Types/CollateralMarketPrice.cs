using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Collateral Market Price: Market price of the collateral, either from external market sources or a result of trading activity on the platform. Clean price
    /// </summary>

    public unsafe struct CollateralMarketPrice
    {
        /// <summary>
        ///  Fix Tag for Collateral Market Price
        /// </summary>
        public const ushort FixTag = 2689;

        /// <summary>
        ///  Decimal place factor for Collateral Market Price
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Size of Collateral Market Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Collateral Market Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Collateral Market Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Collateral Market Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}