using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Display Qty: Visible order qty
    /// </summary>

    public unsafe struct MdDisplayQty
    {
        /// <summary>
        ///  Fix Tag for Md Display Qty
        /// </summary>
        public const ushort FixTag = 37706;

        /// <summary>
        ///  Size of Md Display Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Md Display Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Md Display Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Md Display Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}