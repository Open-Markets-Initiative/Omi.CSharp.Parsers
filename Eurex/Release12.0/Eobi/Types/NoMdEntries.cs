using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  No Md Entries
    /// </summary>

    public struct NoMdEntries
    {
        /// <summary>
        ///  Maximum value for No Md Entries
        /// </summary>
        public const byte Maximum = 15;

        /// <summary>
        ///  Minimum value for No Md Entries
        /// </summary>
        public const byte Minimum = 0;

        /// <summary>
        ///  Length of No Md Entries in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read No Md Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write No Md Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  No Md Entries as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}