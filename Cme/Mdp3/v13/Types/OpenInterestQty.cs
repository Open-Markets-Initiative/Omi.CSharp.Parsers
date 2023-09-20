using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Open Interest Qty: The total open interest for the market at the close of the prior trading session.
    /// </summary>

    public unsafe struct OpenInterestQty
    {
        /// <summary>
        ///  Fix Tag for Open Interest Qty
        /// </summary>
        public const ushort FixTag = 5792;

        /// <summary>
        ///  Length of Open Interest Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Open Interest Qty
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Open Interest Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Open Interest Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Try Read Open Interest Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Open Interest Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Set Open Interest Qty to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Open Interest Qty as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}