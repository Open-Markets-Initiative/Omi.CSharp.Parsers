using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Maturity Date: Maturity Date
    /// </summary>

    public unsafe struct MaturityDate
    {
        /// <summary>
        ///  Fix Tag for Maturity Date
        /// </summary>
        public const ushort FixTag = 541;

        /// <summary>
        ///  Length of Maturity Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Maturity Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Maturity Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Maturity Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}