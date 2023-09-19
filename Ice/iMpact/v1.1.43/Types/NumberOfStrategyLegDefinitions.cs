using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Number Of Strategy Leg Definitions: One Byte Fixed Width Integer
    /// </summary>

    public struct NumberOfStrategyLegDefinitions
    {
        /// <summary>
        ///  Length of Number Of Strategy Leg Definitions in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Number Of Strategy Leg Definitions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Number Of Strategy Leg Definitions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Number Of Strategy Leg Definitions as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}