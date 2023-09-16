using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Intervening Days: For SPOT, number of business days between trade date and value (settlement) date. For NDF, number of business days between NDF valuation (fixing) and settlement
    /// </summary>

    public unsafe struct InterveningDays
    {
        /// <summary>
        ///  Fix Tag for Intervening Days
        /// </summary>
        public const ushort FixTag = 37730;

        /// <summary>
        ///  Length of Intervening Days in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Intervening Days
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Intervening Days
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}