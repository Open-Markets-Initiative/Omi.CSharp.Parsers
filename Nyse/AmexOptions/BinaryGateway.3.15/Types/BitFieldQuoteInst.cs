using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Bit Field Quote Inst: One Byte Fixed Width Integer
    /// </summary>

    public struct BitFieldQuoteInst
    {
        /// <summary>
        ///  Length of Bit Field Quote Inst in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Bit Field Quote Inst
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Bit Field Quote Inst
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Bit Field Quote Inst as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}