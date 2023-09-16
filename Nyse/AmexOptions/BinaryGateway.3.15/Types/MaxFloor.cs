using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Max Floor: 0 = No MaxFloor
    /// </summary>

    public unsafe struct MaxFloor
    {
        /// <summary>
        ///  Length of Max Floor in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Max Floor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Max Floor
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