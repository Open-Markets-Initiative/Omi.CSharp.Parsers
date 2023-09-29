using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Trading Reference Price: Reference price for prelisted instruments or the last calculated Settlement whether it be Theoretical, Preliminary or a Final Settle of the session.
    /// </summary>

    public struct TradingReferencePrice
    {
        /// <summary>
        ///  Fix Tag for Trading Reference Price
        /// </summary>
        public const ushort FixTag = 1150;

        /// <summary>
        ///  Decimal place factor for Trading Reference Price
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Trading Reference Price
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Trading Reference Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Trading Reference Price value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Trading Reference Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Try Read Trading Reference Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Trading Reference Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Set Trading Reference Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Trading Reference Price as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}