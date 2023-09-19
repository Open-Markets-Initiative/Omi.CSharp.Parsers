using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Quote Ack: One Byte Fixed Width Integer
    /// </summary>

    public struct QuoteAck
    {
        /// <summary>
        ///  Length of Quote Ack in bytes
        /// </summary>
        public const int Size = 21;

        /// <summary>
        ///  Read Quote Ack
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Quote Ack
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Quote Ack as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}