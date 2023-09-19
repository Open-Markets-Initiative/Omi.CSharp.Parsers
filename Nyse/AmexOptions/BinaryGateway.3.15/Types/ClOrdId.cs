using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Cl Ord Id: Unique ID of the message as assigned by the firm.
    /// </summary>

    public unsafe struct ClOrdId
    {
        /// <summary>
        ///  Size of Cl Ord Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Cl Ord Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}