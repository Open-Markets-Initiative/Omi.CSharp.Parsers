using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Usd Calculation 4: Integer US Dollar calculation.  For the following RiskControlTypes – will be populated with the
    /// </summary>

    public unsafe struct UsdCalculation4
    {
        /// <summary>
        ///  Size of Usd Calculation 4 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Usd Calculation 4
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return (long)pointer; }
        }

        /// <summary>
        ///  Write Usd Calculation 4
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value; }
        }

        /// <summary>
        ///  Usd Calculation 4 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}