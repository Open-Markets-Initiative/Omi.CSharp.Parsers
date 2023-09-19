using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Contract Multiplier Unit: One Byte Fixed Width Integer
    /// </summary>

    public struct ContractMultiplierUnit
    {
        /// <summary>
        ///  Fix Tag for Contract Multiplier Unit
        /// </summary>
        public const ushort FixTag = 1435;

        /// <summary>
        ///  Length of Contract Multiplier Unit in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Contract Multiplier Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Contract Multiplier Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Contract Multiplier Unit as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}