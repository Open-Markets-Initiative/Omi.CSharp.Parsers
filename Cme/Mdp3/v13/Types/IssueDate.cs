using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Issue Date: Issue Date
    /// </summary>

    public unsafe struct IssueDate
    {
        /// <summary>
        ///  Fix Tag for Issue Date
        /// </summary>
        public const ushort FixTag = 225;

        /// <summary>
        ///  Length of Issue Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Issue Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Issue Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Issue Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Issue Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Issue Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}