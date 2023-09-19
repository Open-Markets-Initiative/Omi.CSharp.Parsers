using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Settl Date: Indicates date of settlement
    /// </summary>

    public unsafe struct SettlDate
    {
        /// <summary>
        ///  Fix Tag for Settl Date
        /// </summary>
        public const ushort FixTag = 64;

        /// <summary>
        ///  Length of Settl Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Settl Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Settl Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Settl Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Settl Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Settl Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}