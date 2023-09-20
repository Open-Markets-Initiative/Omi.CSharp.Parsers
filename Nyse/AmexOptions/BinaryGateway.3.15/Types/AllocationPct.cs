using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Allocation Pct: Percentage of allocation a single stop price Covered order is willing to surrender.
    /// </summary>

    public struct AllocationPct
    {
        /// <summary>
        ///  Length of Allocation Pct in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Allocation Pct
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Allocation Pct
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Allocation Pct as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}