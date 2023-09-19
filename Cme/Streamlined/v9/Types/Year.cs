using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Year: YYYY
    /// </summary>

    public unsafe struct Year
    {
        /// <summary>
        ///  Length of Year in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Year
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Year in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Year as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}