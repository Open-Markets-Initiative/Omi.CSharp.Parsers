using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Msg Length: Total message length, including this header
    /// </summary>

    public struct MsgLength
    {
        /// <summary>
        ///  Size of Msg Length in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Msg Length value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Msg Length as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}