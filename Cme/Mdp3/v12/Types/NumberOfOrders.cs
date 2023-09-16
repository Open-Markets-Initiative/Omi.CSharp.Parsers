using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Number Of Orders: The total number of real orders per instrument that participated in a match step within a match event
    /// </summary>

    public unsafe struct NumberOfOrders
    {
        /// <summary>
        ///  Fix Tag for Number Of Orders
        /// </summary>
        public const ushort FixTag = 346;

        /// <summary>
        ///  Length of Number Of Orders in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Number Of Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Number Of Orders
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