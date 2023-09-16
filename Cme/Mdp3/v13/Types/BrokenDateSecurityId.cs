using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Broken Date Security Id: Broken date Instrument Globex Security ID
    /// </summary>

    public unsafe struct BrokenDateSecurityId
    {
        /// <summary>
        ///  Fix Tag for Broken Date Security Id
        /// </summary>
        public const ushort FixTag = 39027;

        /// <summary>
        ///  Length of Broken Date Security Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Broken Date Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Broken Date Security Id
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