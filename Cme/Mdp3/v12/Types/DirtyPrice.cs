using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Dirty Price: Dirty Price
    /// </summary>

    public unsafe struct DirtyPrice
    {
        /// <summary>
        ///  Fix Tag for Dirty Price
        /// </summary>
        public const ushort FixTag = 37001;

        /// <summary>
        ///  Decimal place factor for Dirty Price
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Size of Dirty Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Dirty Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Dirty Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Dirty Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}