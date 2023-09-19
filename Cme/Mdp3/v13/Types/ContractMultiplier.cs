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
        ///  Length of Contract Multiplier in bytes
        /// </summary>
        public const int Length = 4;

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
        ///  Write Contract Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

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