using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Aggressor Time
    /// </summary>

    public unsafe struct AggressorTime
    {
        /// <summary>
        ///  Size of Aggressor Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Aggressor Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Aggressor Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Aggressor Time as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}