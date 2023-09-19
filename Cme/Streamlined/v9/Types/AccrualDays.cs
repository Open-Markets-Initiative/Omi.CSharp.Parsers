using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Accrual Days: How many days have passed since settlement price was last calculated
    /// </summary>

    public unsafe struct AccrualDays
    {
        /// <summary>
        ///  Fix Tag for Accrual Days
        /// </summary>
        public const ushort FixTag = 7337;

        /// <summary>
        ///  Length of Accrual Days in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Accrual Days
        /// </summary>
        public const uint NoValue = 4294967295;

        /// <summary>
        ///  Size of Accrual Days in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Accrual Days
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Accrual Days
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Accrual Days as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}