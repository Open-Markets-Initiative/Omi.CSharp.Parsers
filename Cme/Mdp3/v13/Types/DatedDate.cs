using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Dated Date: Dated Date
    /// </summary>

    public unsafe struct DatedDate
    {
        /// <summary>
        ///  Fix Tag for Dated Date
        /// </summary>
        public const ushort FixTag = 873;

        /// <summary>
        ///  Length of Dated Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Dated Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Dated Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Dated Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Dated Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Dated Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}