using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Price Level Position: One Byte Fixed Width Integer
    /// </summary>

    public struct PriceLevelPosition
    {
        /// <summary>
        ///  Length of Price Level Position in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Price Level Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Price Level Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Price Level Position as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}