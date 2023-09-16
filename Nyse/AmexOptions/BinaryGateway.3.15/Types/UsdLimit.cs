using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Usd Limit: Integer US Dollar limit.
    /// </summary>

    public unsafe struct UsdLimit
    {
        /// <summary>
        ///  Length of Usd Limit in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Usd Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Usd Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Value;
    }
}