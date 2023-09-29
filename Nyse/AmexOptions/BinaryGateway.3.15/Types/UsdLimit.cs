using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Usd Limit: Integer US Dollar limit.
    /// </summary>

    public struct UsdLimit
    {
        /// <summary>
        ///  Size of Usd Limit in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Usd Limit value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Usd Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying;

        /// <summary>
        ///  Write Usd Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value;

        /// <summary>
        ///  Usd Limit as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}