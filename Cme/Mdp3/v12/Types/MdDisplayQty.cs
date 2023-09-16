using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Display Qty: Visible order qty
    /// </summary>

    public unsafe struct MdDisplayQty
    {
        /// <summary>
        ///  Fix Tag for Md Display Qty
        /// </summary>
        public const ushort FixTag = 37706;

        /// <summary>
        ///  Length of Md Display Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Md Display Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Md Display Qty
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