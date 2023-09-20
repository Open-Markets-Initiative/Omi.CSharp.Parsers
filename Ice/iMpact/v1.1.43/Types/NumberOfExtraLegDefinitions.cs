using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Number Of Extra Leg Definitions: Number of strategy leg definitions. The leg info
    /// </summary>

    public struct NumberOfExtraLegDefinitions
    {
        /// <summary>
        ///  Size of Number Of Extra Leg Definitions in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Number Of Extra Leg Definitions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Number Of Extra Leg Definitions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Number Of Extra Leg Definitions as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}