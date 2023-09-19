using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Leg Date Offset: One Byte Fixed Width Integer
    /// </summary>

    public struct LegDateOffset
    {
        /// <summary>
        ///  Fix Tag for Leg Date Offset
        /// </summary>
        public const ushort FixTag = 37503;

        /// <summary>
        ///  Length of Leg Date Offset in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Leg Date Offset
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Leg Date Offset
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Leg Date Offset as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}