using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Transact Time Optional: Start of event processing time in number of nanoseconds since Unix epoch. Not present for EFP (828=2) and EFR (828=11) transactions
    /// </summary>

    public struct TransactTimeOptional
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
        ///  Transact Time Optional value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Transact Time Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Transact Time Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ulong value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Transact Time Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Set Transact Time Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Transact Time Optional as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}