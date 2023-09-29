using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Next Fixed Payment Date: The date the next fixed payment will be made
    /// </summary>

    public struct NextFixedPaymentDate
    {
        /// <summary>
        ///  Fix Tag for Next Fixed Payment Date
        /// </summary>
        public const ushort FixTag = 38015;

        /// <summary>
        ///  Sentinel null value for Next Fixed Payment Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Next Fixed Payment Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Next Fixed Payment Date value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Next Fixed Payment Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Next Fixed Payment Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Next Fixed Payment Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Set Next Fixed Payment Date to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Next Fixed Payment Date as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}