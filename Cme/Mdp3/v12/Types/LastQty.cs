using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Last Qty: Quantity bought or sold on this last fill
    /// </summary>

    public unsafe struct LastQty
    {
        /// <summary>
        ///  Fix Tag for Last Qty
        /// </summary>
        public const ushort FixTag = 32;

        /// <summary>
        ///  Length of Last Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}