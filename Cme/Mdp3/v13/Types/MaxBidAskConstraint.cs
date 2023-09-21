using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Max Bid Ask Constraint: Maximum bid/ask spread for which sub-tick orders will be accepted (Sub tick orders will be rejected if bid/ask spread is greater than this value)
    /// </summary>

    public unsafe struct MaxBidAskConstraint
    {
        /// <summary>
        ///  Fix Tag for Max Bid Ask Constraint
        /// </summary>
        public const ushort FixTag = 37743;

        /// <summary>
        ///  Decimal place factor for Max Bid Ask Constraint
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Max Bid Ask Constraint
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Max Bid Ask Constraint in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Max Bid Ask Constraint
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Max Bid Ask Constraint
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Max Bid Ask Constraint
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Max Bid Ask Constraint to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Max Bid Ask Constraint as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}