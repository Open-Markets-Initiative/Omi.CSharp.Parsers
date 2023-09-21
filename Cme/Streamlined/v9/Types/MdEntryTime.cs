using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Time: Indicates Market Data Entry Timestamp
    /// </summary>

    public unsafe struct MdEntryTime
    {
        /// <summary>
        ///  Fix Tag for Md Entry Time
        /// </summary>
        public const ushort FixTag = 273;

        /// <summary>
        ///  Sentinel null value for Md Entry Time
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Md Entry Time in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Md Entry Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Try Read Md Entry Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Md Entry Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Set Md Entry Time to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Md Entry Time as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}