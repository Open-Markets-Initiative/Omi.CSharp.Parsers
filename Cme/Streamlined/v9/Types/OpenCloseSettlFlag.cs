using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Open Close Settl Flag: Flag that identifies a market data entry
    /// </summary>

    public struct OpenCloseSettlFlag
    {
        /// <summary>
        ///  Fix Tag for Open Close Settl Flag
        /// </summary>
        public const ushort FixTag = 286;

        /// <summary>
        ///  Length of Open Close Settl Flag in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Open Close Settl Flag
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Open Close Settl Flag
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Open Close Settl Flag as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}