using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Last Px: Price of current partial fill or fill message 0.01 - 9,999.99
    /// </summary>

    public unsafe struct LastPx
    {
        /// <summary>
        ///  Decimal place factor for Last Px
        /// </summary>
        public const long Factor = 100000000;

        /// <summary>
        ///  Size of Last Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Last Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Last Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Last Px as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}