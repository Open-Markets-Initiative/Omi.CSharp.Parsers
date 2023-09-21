using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Max Order Price: Maximum allowable order entry price
    /// </summary>

    public unsafe struct MaxOrderPrice
    {
        /// <summary>
        ///  Decimal place factor for Max Order Price
        /// </summary>
        public const long Factor = 100000000;

        /// <summary>
        ///  Size of Max Order Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Max Order Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Max Order Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Max Order Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}