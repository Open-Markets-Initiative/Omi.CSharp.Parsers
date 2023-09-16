using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Order Id: Unique Order ID
    /// </summary>

    public unsafe struct OrderId
    {
        /// <summary>
        ///  Fix Tag for Order Id
        /// </summary>
        public const ushort FixTag = 37;

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