using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Quantity: 0 - 999,999
    /// </summary>

    public struct Quantity
    {
        /// <summary>
        ///  Size of Quantity in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Quantity value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Quantity as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}