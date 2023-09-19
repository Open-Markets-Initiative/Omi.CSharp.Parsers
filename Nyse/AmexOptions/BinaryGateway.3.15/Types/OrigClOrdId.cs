using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Orig Cl Ord Id: Refers to the ClOrdID of a previously entered order.
    /// </summary>

    public unsafe struct OrigClOrdId
    {
        /// <summary>
        ///  Size of Orig Cl Ord Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Orig Cl Ord Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}