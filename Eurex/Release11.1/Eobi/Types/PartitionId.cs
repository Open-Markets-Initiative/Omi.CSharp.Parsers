using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Partition Id: One Byte Fixed Width Integer
    /// </summary>

    public struct PartitionId
    {
        /// <summary>
        ///  Length of Partition Id in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Partition Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Partition Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Partition Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}