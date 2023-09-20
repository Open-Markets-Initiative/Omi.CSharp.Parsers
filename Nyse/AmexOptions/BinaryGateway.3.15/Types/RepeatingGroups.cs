using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Repeating Groups: Indicates the number of repeating groups included in the message.
    /// </summary>

    public struct RepeatingGroups
    {
        /// <summary>
        ///  Length of Repeating Groups in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Repeating Groups
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Repeating Groups
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Repeating Groups as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}