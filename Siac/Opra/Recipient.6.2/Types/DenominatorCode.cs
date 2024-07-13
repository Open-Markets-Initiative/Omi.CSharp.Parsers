using using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Denominator Code: The Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Bid Price
    /// </summary>

    public struct DenominatorCode
    {
        /// <summary>
        ///  Size of Denominator Code in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Denominator Code value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Denominator Code
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Denominator Code as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}