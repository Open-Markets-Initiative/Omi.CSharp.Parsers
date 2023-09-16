using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Trade Link Id: Contains the workup ID; unique per instrument per day
    /// </summary>

    public unsafe struct TradeLinkId
    {
        /// <summary>
        ///  Fix Tag for Trade Link Id
        /// </summary>
        public const ushort FixTag = 820;

        /// <summary>
        ///  Length of Trade Link Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Trade Link Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Trade Link Id
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