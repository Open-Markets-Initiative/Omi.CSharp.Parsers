using System.Runtime.CompilerServices;

namespace Cme.Streamlined
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
        ///  Sentinel null value for Number Of Orders
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Number Of Orders in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Number Of Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Try Read Number Of Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Number Of Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Set Number Of Orders to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Number Of Orders as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}