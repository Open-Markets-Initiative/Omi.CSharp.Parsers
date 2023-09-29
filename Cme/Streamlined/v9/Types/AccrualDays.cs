using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Accrual Days: How many days have passed since settlement price was last calculated
    /// </summary>

    public struct AccrualDays
    {
        /// <summary>
        ///  Fix Tag for Accrual Days
        /// </summary>
        public const ushort FixTag = 7337;

        /// <summary>
        ///  Sentinel null value for Accrual Days
        /// </summary>
        public const uint NoValue = 4294967295;

        /// <summary>
        ///  Size of Accrual Days in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Accrual Days value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Does Accrual Days field contain a value?
        /// </summary>
        public readonly bool HasValue
            => Underlying != NoValue;

        /// <summary>
        ///  Read Accrual Days
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Accrual Days
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out uint value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Write Accrual Days
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Set Accrual Days to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Accrual Days as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}