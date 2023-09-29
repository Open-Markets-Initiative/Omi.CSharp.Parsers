using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Usd Calculation 3: Integer US Dollar calculation.  For the following RiskControlTypes – will be populated with the
    /// </summary>

    public struct UsdCalculation3
    {
        /// <summary>
        ///  Size of Usd Calculation 3 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Usd Calculation 3 value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Usd Calculation 3
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying;

        /// <summary>
        ///  Write Usd Calculation 3
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value;

        /// <summary>
        ///  Usd Calculation 3 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}