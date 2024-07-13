using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Messages In Block: The Number Of Messages Contained In The Block Data Of The Transmission Block
    /// </summary>

    public struct MessagesInBlock
    {
        /// <summary>
        ///  Length of Messages In Block in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Messages In Block
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Messages In Block
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Messages In Block as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}