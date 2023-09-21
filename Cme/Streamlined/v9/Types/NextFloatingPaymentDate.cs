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
        ///  Try Read Next Floating Payment Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
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
        ///  Set Next Floating Payment Date to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

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