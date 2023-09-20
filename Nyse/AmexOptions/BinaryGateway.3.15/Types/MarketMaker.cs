using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Market Maker: This value represents a Market Maker (including LMM, Primary Specialist, Specialist and e-Specialist), agreed upon between the firm and the Exchange.  These firms must provide their MMID along with its associated MPID on all orders intended to receive credit for satisfying their marking making/liquidity obligations.
    /// </summary>
    public unsafe struct MarketMaker
    {
        /// <summary>
        ///  Size of Market Maker underlying field in bytes
        /// </summary>
        public const int Size = 10;

        /// <summary>
        ///  Read Market Maker from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Market Maker
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Size);

            for (var i = 0; i < end; i++)
            {
                Bytes[i] = (byte)value[i];
            }

            for (var i = end; i < Size; i++)
            {
                Bytes[i] = 0;
            }
        }

        /// <summary>
        ///  Market Maker as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}