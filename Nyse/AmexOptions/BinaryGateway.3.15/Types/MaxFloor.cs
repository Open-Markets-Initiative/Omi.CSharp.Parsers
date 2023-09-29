using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Max Floor: 0 = No MaxFloor
    /// </summary>

    public struct MaxFloor
    {
        /// <summary>
        ///  Size of Max Floor in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Max Floor value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Max Floor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Max Floor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Max Floor as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}