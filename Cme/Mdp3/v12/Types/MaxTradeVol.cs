using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Max Trade Vol: The maximum trading volume for a security
    /// </summary>

    public unsafe struct MaxTradeVol
    {
        /// <summary>
        ///  Fix Tag for Max Trade Vol
        /// </summary>
        public const ushort FixTag = 1140;

        /// <summary>
        ///  Length of Max Trade Vol in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Max Trade Vol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Max Trade Vol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}