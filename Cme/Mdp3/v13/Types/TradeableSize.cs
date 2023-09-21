using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Tradeable Size: Tradeable qty
    /// </summary>

    public unsafe struct TradeableSize
    {
        /// <summary>
        ///  Fix Tag for Tradeable Size
        /// </summary>
        public const ushort FixTag = 37719;

        /// <summary>
        ///  Sentinel null value for Tradeable Size
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Tradeable Size in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Tradeable Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Try Read Tradeable Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Tradeable Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Set Tradeable Size to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Tradeable Size as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}