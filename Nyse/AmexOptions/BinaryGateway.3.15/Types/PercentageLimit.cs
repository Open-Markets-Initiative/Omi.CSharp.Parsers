using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Percentage Limit: Percentage (%).
    /// </summary>

    public unsafe struct PercentageLimit
    {
        /// <summary>
        ///  Length of Percentage Limit in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Percentage Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Percentage Limit
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