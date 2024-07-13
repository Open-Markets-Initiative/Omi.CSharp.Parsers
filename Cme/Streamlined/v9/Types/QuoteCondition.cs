using using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Quote Condition: Condition describing a quote
    /// </summary>

    public struct QuoteCondition
    {
        /// <summary>
        ///  Fix Tag for Quote Condition
        /// </summary>
        public const ushort FixTag = 276;

        /// <summary>
        ///  Size of Quote Condition in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Quote Condition value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Quote Condition
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Quote Condition as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}