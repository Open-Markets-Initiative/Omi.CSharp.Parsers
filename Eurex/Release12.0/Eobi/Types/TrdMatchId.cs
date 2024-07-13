using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Trd Match Id
    /// </summary>

    public struct TrdMatchId
    {
        /// <summary>
        ///  Maximum value for Trd Match Id
        /// </summary>
        public const uint Maximum = 4294967294;

        /// <summary>
        ///  Minimum value for Trd Match Id
        /// </summary>
        public const uint Minimum = 0;

        /// <summary>
        ///  Size of Trd Match Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Trd Match Id value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Trd Match Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}