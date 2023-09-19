using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Leg Ratio Qty: The ratio of quantity for this individual leg relative to the entire multi-leg instrument.
    /// </summary>

    public unsafe struct LegRatioQty
    {
        /// <summary>
        ///  Fix Tag for Leg Ratio Qty
        /// </summary>
        public const ushort FixTag = 623;

        /// <summary>
        ///  Length of Leg Ratio Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Leg Ratio Qty
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Leg Ratio Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Leg Ratio Qty as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}