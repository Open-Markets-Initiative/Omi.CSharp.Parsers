using using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Security Alt Id Source: Identifies class or source of the SecurityAltID (455) value.
    /// </summary>

    public struct SecurityAltIdSource
    {
        /// <summary>
        ///  Fix Tag for Security Alt Id Source
        /// </summary>
        public const ushort FixTag = 456;

        /// <summary>
        ///  Size of Security Alt Id Source in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Security Alt Id Source value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Security Alt Id Source
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Security Alt Id Source as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}