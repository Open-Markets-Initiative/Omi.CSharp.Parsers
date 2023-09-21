using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Price Level Position: Position of the price level
    /// </summary>

    public struct PriceLevelPosition
    {
        /// <summary>
        ///  Size of Price Level Position in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Price Level Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Price Level Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

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