using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Leg Date Offset: Float reset date offset, specified when LegType = FLOAT.
    /// </summary>

    public struct LegDateOffset
    {
        /// <summary>
        ///  Fix Tag for Leg Date Offset
        /// </summary>
        public const ushort FixTag = 37503;

        /// <summary>
        ///  Sentinel null value for Leg Date Offset
        /// </summary>
        public const sbyte NoValue = 127;

        /// <summary>
        ///  Size of Leg Date Offset in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Leg Date Offset
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Leg Date Offset
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Leg Date Offset as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}