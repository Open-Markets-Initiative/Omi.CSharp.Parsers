using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Transact Time Optional: Start of event processing time in number of nanoseconds since Unix epoch. Not present for EFP (828=2) and EFR (828=11) transactions
    /// </summary>

    public unsafe struct TransactTimeOptional
    {
        /// <summary>
        ///  Fix Tag for Transact Time Optional
        /// </summary>
        public const ushort FixTag = 60;

        /// <summary>
        ///  Sentinel null value for Transact Time Optional
        /// </summary>
        public const ulong NoValue = 18446744073709551615;

        /// <summary>
        ///  Size of Transact Time Optional in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Transact Time Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Try Read Transact Time Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ulong value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Transact Time Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Set Transact Time Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Transact Time Optional as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}