using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Count Limit: Integer count.
    /// </summary>

    public struct CountLimit
    {
        /// <summary>
        ///  Size of Count Limit in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Count Limit value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Count Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying;

        /// <summary>
        ///  Write Count Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value;

        /// <summary>
        ///  Count Limit as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}