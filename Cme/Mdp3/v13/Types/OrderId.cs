using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Order Id: Unique Order ID
    /// </summary>

    public unsafe struct OrderId
    {
        /// <summary>
        ///  Fix Tag for Order Id
        /// </summary>
        public const ushort FixTag = 37;

        /// <summary>
        ///  Size of Order Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Order Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}