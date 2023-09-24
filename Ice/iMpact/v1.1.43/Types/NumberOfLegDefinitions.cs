using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Number Of Leg Definitions: Number of strategy leg definitions. The leg info
    /// </summary>

    public struct NumberOfLegDefinitions
    {
        /// <summary>
        ///  Size of Number Of Leg Definitions in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Number Of Leg Definitions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Number Of Leg Definitions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Number Of Leg Definitions as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}