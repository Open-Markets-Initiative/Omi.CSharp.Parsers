using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Par Value: Par value
    /// </summary>

    public struct ParValue
    {
        /// <summary>
        ///  Fix Tag for Par Value
        /// </summary>
        public const ushort FixTag = 37723;

        /// <summary>
        ///  Decimal place factor for Par Value
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Par Value
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Par Value in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Par Value value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Par Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Try Read Par Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Par Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Set Par Value to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Par Value as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}