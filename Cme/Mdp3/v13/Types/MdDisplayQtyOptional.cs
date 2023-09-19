using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Display Qty Optional: Visible qty of order
    /// </summary>

    public unsafe struct MdDisplayQtyOptional
    {
        /// <summary>
        ///  Fix Tag for Md Display Qty Optional
        /// </summary>
        public const ushort FixTag = 37706;

        /// <summary>
        ///  Length of Md Display Qty Optional in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Md Display Qty Optional
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Md Display Qty Optional in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Md Display Qty Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Md Display Qty Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Md Display Qty Optional as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}