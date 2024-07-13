using using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Message Data: Represents The Message Data Field
    /// </summary>

    public struct MessageData
    {
        /// <summary>
        ///  Size of Message Data in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Message Data value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Message Data
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Message Data as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}