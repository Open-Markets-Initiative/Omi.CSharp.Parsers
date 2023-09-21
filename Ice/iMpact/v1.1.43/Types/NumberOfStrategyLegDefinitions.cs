using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Number Of Strategy Leg Definitions: Number of strategy leg definitions. The leg info are in repeating group followed
    /// </summary>

    public struct NumberOfStrategyLegDefinitions
    {
        /// <summary>
        ///  Size of Number Of Strategy Leg Definitions in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Number Of Strategy Leg Definitions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Number Of Strategy Leg Definitions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

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