using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Alt Price Increment Constraint: Minimum price offset better than the best Standard Tick order for an order to be allowed into the market
    /// </summary>

    public unsafe struct AltPriceIncrementConstraint
    {
        /// <summary>
        ///  Fix Tag for Alt Price Increment Constraint
        /// </summary>
        public const ushort FixTag = 37742;

        /// <summary>
        ///  Decimal place factor for Alt Price Increment Constraint
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Alt Price Increment Constraint
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Alt Price Increment Constraint in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Alt Price Increment Constraint
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Alt Price Increment Constraint
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Alt Price Increment Constraint
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Alt Price Increment Constraint to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Alt Price Increment Constraint as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}