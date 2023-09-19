using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Cross Id: Unique ID of the Cross as assigned by the firm.
    /// </summary>

    public unsafe struct CrossId
    {
        /// <summary>
        ///  Size of Cross Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Cross Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}