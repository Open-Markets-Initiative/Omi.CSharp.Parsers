using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Ack Status: One Byte Fixed Width Integer
    /// </summary>

    public struct AckStatus
    {
        /// <summary>
        ///  Length of Ack Status in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Ack Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Ack Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Ack Status as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}