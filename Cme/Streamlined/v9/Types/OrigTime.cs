using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Orig Time: Time of message origination expressed as number of nanoseconds since unix epoch
    /// </summary>

    public struct OrigTime
    {
        /// <summary>
        ///  Fix Tag for Orig Time
        /// </summary>
        public const ushort FixTag = 42;

        /// <summary>
        ///  Sentinel null value for Orig Time
        /// </summary>
        public const ulong NoValue = 18446744073709551615;

        /// <summary>
        ///  Size of Orig Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Orig Time value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Orig Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Orig Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ulong value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Orig Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Set Orig Time to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Orig Time as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}