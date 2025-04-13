using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{

    /// <summary>
    ///  Match Algorithm: Matching algorithm
    /// </summary>

    public struct MatchAlgorithm
    {
        /// <summary>
        ///  Fix Tag for Match Algorithm
        /// </summary>
        public const ushort FixTag = 1142;

        /// <summary>
        ///  Size of Match Algorithm in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Match Algorithm value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Match Algorithm
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Match Algorithm as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}