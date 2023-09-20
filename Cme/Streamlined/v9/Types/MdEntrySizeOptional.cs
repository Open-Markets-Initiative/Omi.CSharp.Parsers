using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Size Optional: Quantity or volume represented by the Market Data Entry
    /// </summary>

    public unsafe struct MdEntrySizeOptional
    {
        /// <summary>
        ///  Fix Tag for Md Entry Size Optional
        /// </summary>
        public const ushort FixTag = 271;

        /// <summary>
        ///  Length of Md Entry Size Optional in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Sentinel null value for Md Entry Size Optional
        /// </summary>
        public const ulong NoValue = 18446744073709551615;

        /// <summary>
        ///  Size of Md Entry Size Optional in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Md Entry Size Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Try Read Md Entry Size Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ulong value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Md Entry Size Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Set Md Entry Size Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Md Entry Size Optional as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}