using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Leg Option Delta: Delta used to calculate the quantity of futures used to cover the option or option strategy
    /// </summary>

    public unsafe struct LegOptionDelta
    {
        /// <summary>
        ///  Fix Tag for Leg Option Delta
        /// </summary>
        public const ushort FixTag = 1017;

        /// <summary>
        ///  Decimal place factor for Leg Option Delta
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Sentinel null value for Leg Option Delta
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Leg Option Delta in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Leg Option Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return ((int)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Leg Option Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Leg Option Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Leg Option Delta to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Leg Option Delta as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}