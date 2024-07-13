using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Month: MM
    /// </summary>

    public struct Month
    {
        /// <summary>
        ///  Sentinel null value for Month
        /// </summary>
        public const byte NoValue = 255;

        /// <summary>
        ///  Length of Month in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Month
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Month
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Month as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}