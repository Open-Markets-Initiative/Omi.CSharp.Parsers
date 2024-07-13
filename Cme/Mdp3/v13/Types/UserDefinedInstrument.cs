using using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  User Defined Instrument: User-defined instruments flag
    /// </summary>

    public struct UserDefinedInstrument
    {
        /// <summary>
        ///  Fix Tag for User Defined Instrument
        /// </summary>
        public const ushort FixTag = 9779;

        /// <summary>
        ///  Size of User Defined Instrument in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  User Defined Instrument value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write User Defined Instrument
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  User Defined Instrument as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}