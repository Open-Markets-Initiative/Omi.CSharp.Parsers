using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Is Adjusted Trade: Indicate if the trade is an adjusted trade, ‘Y’ or ‘N’
    /// </summary>

    public struct IsAdjustedTrade
    {
        /// <summary>
        ///  Size of Is Adjusted Trade in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Is Adjusted Trade value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Is Adjusted Trade
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Is Adjusted Trade as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}