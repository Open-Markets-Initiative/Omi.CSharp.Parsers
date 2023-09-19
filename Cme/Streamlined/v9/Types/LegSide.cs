using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Leg Side: One Byte Fixed Width Integer
    /// </summary>

    public struct LegSide
    {
        /// <summary>
        ///  Fix Tag for Leg Side
        /// </summary>
        public const ushort FixTag = 624;

        /// <summary>
        ///  Length of Leg Side in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Leg Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Leg Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Leg Side as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}