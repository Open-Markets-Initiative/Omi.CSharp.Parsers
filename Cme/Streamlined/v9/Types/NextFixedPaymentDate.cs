using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Next Fixed Payment Date: The date the next fixed payment will be made
    /// </summary>

    public unsafe struct NextFixedPaymentDate
    {
        /// <summary>
        ///  Fix Tag for Next Fixed Payment Date
        /// </summary>
        public const ushort FixTag = 38015;

        /// <summary>
        ///  Length of Next Fixed Payment Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Next Fixed Payment Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Next Fixed Payment Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Next Fixed Payment Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Next Fixed Payment Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Next Fixed Payment Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}