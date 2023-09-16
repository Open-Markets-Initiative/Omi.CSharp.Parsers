using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Msg Length: Total message length, including this header
    /// </summary>

    public unsafe struct MsgLength
    {
        /// <summary>
        ///  Length of Msg Length in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Msg Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}