using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Series Index: Options series index
    /// </summary>

    public struct SeriesIndex
    {
        /// <summary>
        ///  Size of Series Index in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Series Index value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Series Index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Series Index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Series Index as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}