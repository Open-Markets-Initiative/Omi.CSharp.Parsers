using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Underlying Security Id: Unique Instrument ID as qualified by the exchange per tag 305-UnderlyingSecurityIDSource
    /// </summary>

    public unsafe struct UnderlyingSecurityId
    {
        /// <summary>
        ///  Fix Tag for Underlying Security Id
        /// </summary>
        public const ushort FixTag = 309;

        /// <summary>
        ///  Length of Underlying Security Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Underlying Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Underlying Security Id
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