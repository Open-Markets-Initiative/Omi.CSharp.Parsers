using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Trade Id: Unique Trade Entry ID per Instrument  and Trading Date
    /// </summary>

    public unsafe struct TradeId
    {
        /// <summary>
        ///  Fix Tag for Trade Id
        /// </summary>
        public const ushort FixTag = 1003;

        /// <summary>
        ///  Length of Trade Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}