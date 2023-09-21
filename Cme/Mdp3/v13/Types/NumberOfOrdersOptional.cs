using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Number Of Orders Optional: In Book entry - aggregate number of orders at given price level
    /// </summary>

    public unsafe struct NumberOfOrdersOptional
    {
        /// <summary>
        ///  Fix Tag for Number Of Orders Optional
        /// </summary>
        public const ushort FixTag = 346;

        /// <summary>
        ///  Sentinel null value for Number Of Orders Optional
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Number Of Orders Optional in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Number Of Orders Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Try Read Number Of Orders Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Number Of Orders Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Set Number Of Orders Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Number Of Orders Optional as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}