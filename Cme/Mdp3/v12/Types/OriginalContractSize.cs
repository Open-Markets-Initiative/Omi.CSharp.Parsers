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
        ///  Try Read Original Contract Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
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
        ///  Set Original Contract Size to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Original Contract Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}