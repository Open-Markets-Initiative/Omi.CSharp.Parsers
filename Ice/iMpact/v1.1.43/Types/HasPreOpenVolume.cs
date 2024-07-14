using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Has Pre Open Volume: Indicates message contains PreOpenVolume. ‘Y’ or ‘N’
    /// </summary>

    public struct HasPreOpenVolume
    {
        /// <summary>
        ///  Size of Has Pre Open Volume in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Has Pre Open Volume value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Has Pre Open Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Has Pre Open Volume as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}