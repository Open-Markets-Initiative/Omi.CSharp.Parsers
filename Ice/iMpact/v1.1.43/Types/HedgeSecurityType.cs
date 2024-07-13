using using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Security Type: Futures
    /// </summary>

    public struct HedgeSecurityType
    {
        /// <summary>
        ///  Size of Hedge Security Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Hedge Security Type value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Hedge Security Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Hedge Security Type as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}