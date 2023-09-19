using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Quote Type: One Byte Fixed Width Integer
    /// </summary>

    public struct QuoteType
    {
        /// <summary>
        ///  Fix Tag for Quote Type
        /// </summary>
        public const ushort FixTag = 537;

        /// <summary>
        ///  Length of Quote Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Quote Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Quote Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Quote Type as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}