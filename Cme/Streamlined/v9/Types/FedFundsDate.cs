using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Fed Funds Date: The date that the for which the fed funds date was published
    /// </summary>

    public struct FedFundsDate
    {
        /// <summary>
        ///  Fix Tag for Fed Funds Date
        /// </summary>
        public const ushort FixTag = 38010;

        /// <summary>
        ///  Sentinel null value for Fed Funds Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Fed Funds Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Fed Funds Date value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Fed Funds Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Fed Funds Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Fed Funds Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Set Fed Funds Date to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Fed Funds Date as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}