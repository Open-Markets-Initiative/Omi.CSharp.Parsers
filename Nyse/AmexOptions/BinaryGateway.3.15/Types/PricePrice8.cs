using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Price Price 8: 0.01 - 9,999.99
    /// </summary>

    public unsafe struct PricePrice8
    {
        /// <summary>
        ///  Decimal place factor for Price Price 8
        /// </summary>
        public const long Factor = 100000000;

        /// <summary>
        ///  Size of Price Price 8 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Price Price 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Price Price 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Price Price 8 as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}