using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Order Id Optional: Order ID
    /// </summary>

    public unsafe struct OrderIdOptional
    {
        /// <summary>
        ///  Fix Tag for Order Id Optional
        /// </summary>
        public const ushort FixTag = 37;

        /// <summary>
        ///  Length of Order Id Optional in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Sentinel null value for Order Id Optional
        /// </summary>
        public const ulong NoValue = 18446744073709551615;

        /// <summary>
        ///  Size of Order Id Optional in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Order Id Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Try Read Order Id Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ulong value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Order Id Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Set Order Id Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Order Id Optional as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}