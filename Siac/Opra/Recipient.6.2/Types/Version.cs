using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Version: Designates The Opra Binary Version
    /// </summary>

    public struct Version
    {
        /// <summary>
        ///  Required value for Version
        /// </summary>
        public const byte StaticValue = 6;

        /// <summary>
        ///  Length of Version in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Version
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Version
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Version as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}