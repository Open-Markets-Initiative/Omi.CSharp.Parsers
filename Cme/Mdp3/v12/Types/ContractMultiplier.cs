using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Contract Multiplier: Number of deliverable units per instrument, e.g., peak days in maturity month or number of calendar days in maturity month
    /// </summary>

    public unsafe struct ContractMultiplier
    {
        /// <summary>
        ///  Fix Tag for Contract Multiplier
        /// </summary>
        public const ushort FixTag = 231;

        /// <summary>
        ///  Sentinel null value for Contract Multiplier
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Contract Multiplier in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Contract Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Try Read Contract Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Contract Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Set Contract Multiplier to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Contract Multiplier as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}