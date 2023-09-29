using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Trading Reference Date: Indicates the business date for previous settlement price
    /// </summary>

    public struct TradingReferenceDate
    {
        /// <summary>
        ///  Fix Tag for Trading Reference Date
        /// </summary>
        public const ushort FixTag = 5796;

        /// <summary>
        ///  Sentinel null value for Trading Reference Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Trading Reference Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Trading Reference Date value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Trading Reference Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Trading Reference Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Trading Reference Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Set Trading Reference Date to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Trading Reference Date as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}