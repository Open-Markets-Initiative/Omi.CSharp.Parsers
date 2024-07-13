using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Quote Type: Identifies the type of quote. 0=Indicative, 1=Tradeable
    /// </summary>

    public struct MdQuoteType
    {
        /// <summary>
        ///  Fix Tag for Md Quote Type
        /// </summary>
        public const ushort FixTag = 1070;

        /// <summary>
        ///  Sentinel null value for Md Quote Type
        /// </summary>
        public const byte NoValue = 255;

        /// <summary>
        ///  Length of Md Quote Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Md Quote Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Md Quote Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Md Quote Type as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}