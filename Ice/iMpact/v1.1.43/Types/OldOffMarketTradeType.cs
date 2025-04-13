using System.Runtime.CompilerServices;

namespace Ice.iMpact
{

    /// <summary>
    ///  Old Off Market Trade Type: Legacy field that supports all single character trade types on ICE. The new 3-character “OffMarketTradeType” field replaces this field. In the future (no earlier than 2015), ICE anticipates the introduction of 3 character trade types that will only be available in the new field. Trade types that are longer than a single character will be represented with “#” in this field.
    /// </summary>

    public struct OldOffMarketTradeType
    {
        /// <summary>
        ///  Size of Old Off Market Trade Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Old Off Market Trade Type value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Old Off Market Trade Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Old Off Market Trade Type as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}