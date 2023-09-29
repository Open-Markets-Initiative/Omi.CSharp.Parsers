using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Batch Total Messages Optional: Total number of messages contained within batch which is defined by match event indicator (5799)
    /// </summary>

    public struct BatchTotalMessagesOptional
    {
        /// <summary>
        ///  Fix Tag for Batch Total Messages Optional
        /// </summary>
        public const ushort FixTag = 50001;

        /// <summary>
        ///  Sentinel null value for Batch Total Messages Optional
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Batch Total Messages Optional in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Batch Total Messages Optional value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Does Batch Total Messages Optional field contain a value?
        /// </summary>
        public readonly bool HasValue
            => Underlying != NoValue;

        /// <summary>
        ///  Read Batch Total Messages Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Batch Total Messages Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ushort value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Write Batch Total Messages Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Set Batch Total Messages Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Batch Total Messages Optional as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}