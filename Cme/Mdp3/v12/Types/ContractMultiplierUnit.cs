using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Contract Multiplier Unit: Indicates the type of multiplier being applied to the product. Optionally used in combination with tag 231-ContractMultiplier
    /// </summary>

    public struct ContractMultiplierUnit
    {
        /// <summary>
        ///  Fix Tag for Contract Multiplier Unit
        /// </summary>
        public const ushort FixTag = 1435;

        /// <summary>
        ///  Size of Contract Multiplier Unit in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Contract Multiplier Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Contract Multiplier Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Contract Multiplier Unit as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}