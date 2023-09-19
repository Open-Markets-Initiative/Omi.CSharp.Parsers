using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Trd Type: One Byte Fixed Width Integer
    /// </summary>

    public struct TrdType
    {
        /// <summary>
        ///  Fix Tag for Trd Type
        /// </summary>
        public const ushort FixTag = 828;

        /// <summary>
        ///  Length of Trd Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Trd Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Trd Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Trd Type as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}