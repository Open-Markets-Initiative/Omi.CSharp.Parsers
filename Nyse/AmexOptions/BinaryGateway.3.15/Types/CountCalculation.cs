using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Count Calculation: Integer count.
    /// </summary>

    public struct CountCalculation
    {
        /// <summary>
        ///  Size of Count Calculation in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Count Calculation value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Count Calculation
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Count Calculation
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Count Calculation as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}