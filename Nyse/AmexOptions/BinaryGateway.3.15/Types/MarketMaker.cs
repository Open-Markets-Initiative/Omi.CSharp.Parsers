using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Market Maker: This value represents a Market Maker (including LMM, Primary Specialist, Specialist and e-Specialist), agreed upon between the firm and the Exchange.  These firms must provide their MMID along with its associated MPID on all orders intended to receive credit for satisfying their marking making/liquidity obligations.
    /// </summary>
    public struct MarketMaker
    {
        /// <summary>
        ///  Length of Market Maker in bytes
        /// </summary>
        public const int Length = 10;

        /// <summary>
        ///  Read Market Maker from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Market Maker
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Length);

            for (var i = 0; i < end; i++)
            {
                Buffer[i] = (byte)value[i];
            }

            for (var i = end; i < Length; i++)
            {
                Buffer[i] = 0;
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
        internal unsafe fixed byte Buffer[Length];
    }
}