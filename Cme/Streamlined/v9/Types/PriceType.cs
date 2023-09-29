using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Price Type: Valid price types for intraday trade
    /// </summary>

    public struct PriceType
    {
        /// <summary>
        ///  Fix Tag for Price Type
        /// </summary>
        public const ushort FixTag = 423;

        /// <summary>
        ///  Sentinel null value for Price Type
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Price Type in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Price Type value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Price Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Price Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Price Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Set Price Type to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Price Type as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}