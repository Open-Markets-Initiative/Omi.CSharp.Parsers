using System.Runtime.CompilerServices;

namespace Iex.Tops
{

    /// <summary>
    ///  Extension Number: Number of extensions an auction received
    /// </summary>

    public struct ExtensionNumber
    {
        /// <summary>
        ///  Size of Extension Number in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Extension Number value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Extension Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Extension Number as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}