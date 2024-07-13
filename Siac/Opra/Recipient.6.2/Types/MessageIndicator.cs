using using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Message Indicator: Message Identifier
    /// </summary>

    public struct MessageIndicator
    {
        /// <summary>
        ///  Size of Message Indicator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Message Indicator value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Message Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Message Indicator as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}