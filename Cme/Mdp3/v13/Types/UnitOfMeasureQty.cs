using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Unit Of Measure Qty: This field contains the contract size for each instrument. Used in combination with tag 996-UnitofMeasure
    /// </summary>

    public unsafe struct UnitOfMeasureQty
    {
        /// <summary>
        ///  Fix Tag for Unit Of Measure Qty
        /// </summary>
        public const ushort FixTag = 1147;

        /// <summary>
        ///  Decimal place factor for Unit Of Measure Qty
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Unit Of Measure Qty
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Unit Of Measure Qty in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Unit Of Measure Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Unit Of Measure Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Unit Of Measure Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Unit Of Measure Qty to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Unit Of Measure Qty as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}