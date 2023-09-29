using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Time Limit: Microsecond time period.
    /// </summary>

    public struct TimeLimit
    {
        /// <summary>
        ///  Size of Time Limit in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Time Limit value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Time Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying;

        /// <summary>
        ///  Write Time Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value;

        /// <summary>
        ///  Time Limit as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}