using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Id: Unique identifier of most recent order as assigned by the Exchange. Published externally to market data feeds
    /// </summary>

    public struct OrderId
    {
        /// <summary>
        ///  Size of Order Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Order Id value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Order Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}