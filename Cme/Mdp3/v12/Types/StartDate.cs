using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Start Date: Start date of a financing deal, i.e. the date the buyer pays the seller cash and takes control of the collateral
    /// </summary>

    public unsafe struct StartDate
    {
        /// <summary>
        ///  Fix Tag for Start Date
        /// </summary>
        public const ushort FixTag = 916;

        /// <summary>
        ///  Length of Start Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Start Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Start Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Start Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Start Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Start Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}