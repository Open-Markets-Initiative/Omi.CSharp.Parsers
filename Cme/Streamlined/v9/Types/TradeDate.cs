using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Trade Date: Indicates date of trade referenced in this message in YYYYMMDD format (expressed in local time at place of trade). Returned only in trade and trade cancel execution reports.
    /// </summary>

    public unsafe struct TradeDate
    {
        /// <summary>
        ///  Fix Tag for Trade Date
        /// </summary>
        public const ushort FixTag = 75;

        /// <summary>
        ///  Length of Trade Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Trade Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Trade Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Try Read Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Set Trade Date to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Trade Date as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}