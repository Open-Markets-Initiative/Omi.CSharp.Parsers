using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Trd Reg Ts Execution Time
    /// </summary>

    public unsafe struct TrdRegTsExecutionTime
    {
        /// <summary>
        ///  Size of Trd Reg Ts Execution Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Trd Reg Ts Execution Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Trd Reg Ts Execution Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Trd Reg Ts Execution Time as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}