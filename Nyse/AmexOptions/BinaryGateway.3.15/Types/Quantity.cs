using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Quantity: 0 - 999,999
    /// </summary>

    public unsafe struct Quantity
    {
        /// <summary>
        ///  Length of Quantity in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}