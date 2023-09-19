using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Size u Int 64 Null: Aggregate booked qty at price level, notional
    /// </summary>

    public unsafe struct MdEntrySizeUInt64Null
    {
        /// <summary>
        ///  Fix Tag for Md Entry Size u Int 64 Null
        /// </summary>
        public const ushort FixTag = 271;

        /// <summary>
        ///  Length of Md Entry Size u Int 64 Null in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Sentinel null value for Md Entry Size u Int 64 Null
        /// </summary>
        public const ulong NoValue = 18446744073709551615;

        /// <summary>
        ///  Size of Md Entry Size u Int 64 Null in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Md Entry Size u Int 64 Null
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Md Entry Size u Int 64 Null
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Md Entry Size u Int 64 Null as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}