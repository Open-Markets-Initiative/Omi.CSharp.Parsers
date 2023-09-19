using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Trd Reg Ts Time Priority
    /// </summary>

    public unsafe struct TrdRegTsTimePriority
    {
        /// <summary>
        ///  Size of Trd Reg Ts Time Priority in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Trd Reg Ts Time Priority
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Trd Reg Ts Time Priority
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Trd Reg Ts Time Priority as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}