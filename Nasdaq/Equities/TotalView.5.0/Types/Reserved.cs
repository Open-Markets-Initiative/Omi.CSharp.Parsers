using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Reserved: Reserved
    /// </summary>

    public struct Reserved
    {
        /// <summary>
        ///  Size of Reserved in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Reserved value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Reserved
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Reserved as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}