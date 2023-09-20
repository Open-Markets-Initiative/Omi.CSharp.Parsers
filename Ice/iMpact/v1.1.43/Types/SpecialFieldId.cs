using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Special Field Id: Special Field Identifier
    /// </summary>

    public struct SpecialFieldId
    {
        /// <summary>
        ///  Length of Special Field Id in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Special Field Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Special Field Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Special Field Id as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}