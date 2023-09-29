using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Seq Msg Length: Length of sequenced data message including this field
    /// </summary>

    public struct SeqMsgLength
    {
        /// <summary>
        ///  Size of Seq Msg Length in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Seq Msg Length value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Seq Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Seq Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Seq Msg Length as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}