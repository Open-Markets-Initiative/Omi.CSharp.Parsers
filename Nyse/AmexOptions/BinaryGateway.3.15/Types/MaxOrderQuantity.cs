using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Max Order Quantity: Maximum allowable OrderQty for Order and Cancel/Replace Requests entered on the gateway session.
    /// </summary>

    public unsafe struct MaxOrderQuantity
    {
        /// <summary>
        ///  Size of Max Order Quantity in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Max Order Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Max Order Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Max Order Quantity as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}