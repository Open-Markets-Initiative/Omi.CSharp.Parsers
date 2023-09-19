using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Usd Calculation 1: Integer US Dollar calculation.  For the following RiskControlTypes – will be populated with the
    /// </summary>

    public unsafe struct UsdCalculation1
    {
        /// <summary>
        ///  Size of Usd Calculation 1 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Usd Calculation 1
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return (long)pointer; }
        }

        /// <summary>
        ///  Write Usd Calculation 1
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value; }
        }

        /// <summary>
        ///  Usd Calculation 1 as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}