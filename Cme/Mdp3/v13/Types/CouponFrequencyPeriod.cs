using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Coupon Frequency Period: Time unit multiplier for the frequency of the bond's coupon payment
    /// </summary>

    public unsafe struct CouponFrequencyPeriod
    {
        /// <summary>
        ///  Fix Tag for Coupon Frequency Period
        /// </summary>
        public const ushort FixTag = 1948;

        /// <summary>
        ///  Length of Coupon Frequency Period in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Coupon Frequency Period
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Coupon Frequency Period in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Coupon Frequency Period
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Try Read Coupon Frequency Period
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Coupon Frequency Period
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Set Coupon Frequency Period to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Coupon Frequency Period as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}