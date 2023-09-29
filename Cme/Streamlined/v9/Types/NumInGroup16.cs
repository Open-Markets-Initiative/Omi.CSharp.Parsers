using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Num In Group 16
    /// </summary>

    public struct NumInGroup16
    {
        /// <summary>
        ///  Size of Num In Group 16 in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Num In Group 16 value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Num In Group 16
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Num In Group 16
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Num In Group 16 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}