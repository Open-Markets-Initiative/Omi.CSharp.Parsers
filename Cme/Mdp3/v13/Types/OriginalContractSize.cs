using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Original Contract Size: Fixed contract value assigned to each product
    /// </summary>

    public unsafe struct OriginalContractSize
    {
        /// <summary>
        ///  Fix Tag for Original Contract Size
        /// </summary>
        public const ushort FixTag = 5849;

        /// <summary>
        ///  Length of Original Contract Size in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Original Contract Size
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Original Contract Size in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Original Contract Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Original Contract Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Original Contract Size as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}