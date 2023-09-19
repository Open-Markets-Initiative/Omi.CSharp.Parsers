using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Next Floating Payment Date: The date the next floating payment will be made
    /// </summary>

    public unsafe struct NextFloatingPaymentDate
    {
        /// <summary>
        ///  Fix Tag for Next Floating Payment Date
        /// </summary>
        public const ushort FixTag = 38018;

        /// <summary>
        ///  Length of Next Floating Payment Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Next Floating Payment Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Next Floating Payment Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Next Floating Payment Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Next Floating Payment Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Next Floating Payment Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}