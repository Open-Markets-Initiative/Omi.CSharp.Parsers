using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Leg Ratio Qty: One Byte Fixed Width Integer
    /// </summary>

    public struct LegRatioQty
    {
        /// <summary>
        ///  Fix Tag for Leg Ratio Qty
        /// </summary>
        public const ushort FixTag = 623;

        /// <summary>
        ///  Length of Leg Ratio Qty in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Leg Ratio Qty as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}