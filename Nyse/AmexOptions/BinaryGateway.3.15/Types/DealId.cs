using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Deal Id: Unique identifier of a transaction, assigned by the Exchange to both Execution reports representing the two sides of a single trade. Published externally to market data feeds.
    /// </summary>

    public unsafe struct DealId
    {
        /// <summary>
        ///  Length of Deal Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Deal Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Deal Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Value;
    }
}