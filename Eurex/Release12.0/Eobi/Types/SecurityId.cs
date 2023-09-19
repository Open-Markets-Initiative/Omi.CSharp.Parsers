using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Security Id
    /// </summary>

    public unsafe struct SecurityId
    {
        /// <summary>
        ///  Size of Security Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return (long)pointer; }
        }

        /// <summary>
        ///  Write Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value; }
        }

        /// <summary>
        ///  Security Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}