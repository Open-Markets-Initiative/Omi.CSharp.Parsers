using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Day: DD
    /// </summary>

    public struct Day
    {
        /// <summary>
        ///  Sentinel null value for Day
        /// </summary>
        public const byte NoValue = 255;

        /// <summary>
        ///  Length of Day in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Day
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Day
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Day as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}