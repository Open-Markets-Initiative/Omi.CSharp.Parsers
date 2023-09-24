using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Trade Id: Unique Trade Entry ID per Instrument  and Trading Date
    /// </summary>

    public unsafe struct TradeId
    {
        /// <summary>
        ///  Fix Tag for Trade Id
        /// </summary>
        public const ushort FixTag = 1003;

        /// <summary>
        ///  Size of Trade Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Trade Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}