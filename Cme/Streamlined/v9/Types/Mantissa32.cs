using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Mantissa 32: mantissa
    /// </summary>

    public unsafe struct Mantissa32
    {
        /// <summary>
        ///  Length of Mantissa 32 in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Mantissa 32
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Mantissa 32 in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Mantissa 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Mantissa 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Mantissa 32 as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}