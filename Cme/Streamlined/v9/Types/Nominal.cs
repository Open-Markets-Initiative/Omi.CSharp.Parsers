using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Nominal: This is the notional value used to calculate NPV and Fixed and Floating Payment amounts
    /// </summary>

    public unsafe struct Nominal
    {
        /// <summary>
        ///  Fix Tag for Nominal
        /// </summary>
        public const ushort FixTag = 9280;

        /// <summary>
        ///  Sentinel null value for Nominal
        /// </summary>
        public const ulong NoValue = 18446744073709551615;

        /// <summary>
        ///  Size of Nominal in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Nominal
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Try Read Nominal
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ulong value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Nominal
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Set Nominal to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Nominal as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}