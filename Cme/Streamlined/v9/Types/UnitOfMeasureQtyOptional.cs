using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Unit Of Measure Qty Optional: This field contains the notional value for each instrument. The notional value is equivalent to the corresponding premium-quoted contract
    /// </summary>

    public unsafe struct UnitOfMeasureQtyOptional
    {
        /// <summary>
        ///  Fix Tag for Unit Of Measure Qty Optional
        /// </summary>
        public const ushort FixTag = 1147;

        /// <summary>
        ///  Decimal place factor for Unit Of Measure Qty Optional
        /// </summary>
        public const long Factor = 10000000;

        /// <summary>
        ///  Sentinel null value for Unit Of Measure Qty Optional
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Unit Of Measure Qty Optional in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Unit Of Measure Qty Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Unit Of Measure Qty Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Unit Of Measure Qty Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Unit Of Measure Qty Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Unit Of Measure Qty Optional as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}