using System.Runtime.CompilerServices;

namespace Siac.Recipient
{

    /// <summary>
    ///  Message Type: Message Type
    /// </summary>

    public struct MessageType
    {
        /// <summary>
        ///  Size of Message Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Message Type value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Message Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Message Type as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}