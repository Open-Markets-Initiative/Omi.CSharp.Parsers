using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Stop Px: Trigger price for Stop and Stop Limit orders
    /// </summary>

    public unsafe struct StopPx
    {
        /// <summary>
        ///  Decimal place factor for Stop Px
        /// </summary>
        public const long Factor = 100000000;

        /// <summary>
        ///  Size of Stop Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Stop Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Stop Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Stop Px as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}