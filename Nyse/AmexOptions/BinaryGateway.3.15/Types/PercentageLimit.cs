using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Percentage Limit: Percentage (%).
    /// </summary>

    public struct PercentageLimit
    {
        /// <summary>
        ///  Size of Percentage Limit in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Percentage Limit value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Percentage Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying;

        /// <summary>
        ///  Write Percentage Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value;

        /// <summary>
        ///  Percentage Limit as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}