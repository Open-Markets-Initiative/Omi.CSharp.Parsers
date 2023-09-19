using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Mantissa: mantissa
    /// </summary>

    public unsafe struct Mantissa
    {
        /// <summary>
        ///  Length of Mantissa in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Sentinel null value for Mantissa
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Mantissa in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Mantissa
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return (long)pointer; }
        }

        /// <summary>
        ///  Write Mantissa
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value; }
        }

        /// <summary>
        ///  Mantissa as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}