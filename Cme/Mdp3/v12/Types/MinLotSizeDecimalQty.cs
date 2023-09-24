using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Min Lot Size Decimal Qty: Minimum quantity accepted for order entry. If tag 1093-LotType=4, this value is the minimum quantity for order entry expressed in the applicable units, specified in tag 996-UnitOfMeasure, e.g. megawatts
    /// </summary>

    public unsafe struct MinLotSizeDecimalQty
    {
        /// <summary>
        ///  Fix Tag for Min Lot Size Decimal Qty
        /// </summary>
        public const ushort FixTag = 1231;

        /// <summary>
        ///  Decimal place factor for Min Lot Size Decimal Qty
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Sentinel null value for Min Lot Size Decimal Qty
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Min Lot Size Decimal Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Min Lot Size Decimal Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return ((int)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Min Lot Size Decimal Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Min Lot Size Decimal Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Min Lot Size Decimal Qty to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Min Lot Size Decimal Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}