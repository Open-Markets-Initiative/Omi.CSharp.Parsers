using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Put Or Call: One Byte Fixed Width Integer
    /// </summary>

    public struct PutOrCall
    {
        /// <summary>
        ///  Fix Tag for Put Or Call
        /// </summary>
        public const ushort FixTag = 201;

        /// <summary>
        ///  Length of Put Or Call in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Put Or Call
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Put Or Call
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Put Or Call as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}