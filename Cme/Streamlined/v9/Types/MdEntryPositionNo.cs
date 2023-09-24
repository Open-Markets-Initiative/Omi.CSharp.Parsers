using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Position No: Position in the book.
    /// </summary>

    public unsafe struct MdEntryPositionNo
    {
        /// <summary>
        ///  Fix Tag for Md Entry Position No
        /// </summary>
        public const ushort FixTag = 290;

        /// <summary>
        ///  Sentinel null value for Md Entry Position No
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Md Entry Position No in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Md Entry Position No
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Try Read Md Entry Position No
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Md Entry Position No
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Set Md Entry Position No to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Md Entry Position No as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}