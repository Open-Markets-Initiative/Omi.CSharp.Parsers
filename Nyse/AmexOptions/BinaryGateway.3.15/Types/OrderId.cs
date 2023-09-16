using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Id: Unique identifier of most recent order as assigned by the Exchange. Published externally to market data feeds
    /// </summary>

    public unsafe struct OrderId
    {
        /// <summary>
        ///  Length of Order Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Order Id
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