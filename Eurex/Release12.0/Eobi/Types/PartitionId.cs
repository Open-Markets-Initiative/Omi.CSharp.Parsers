using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Partition Id
    /// </summary>

    public struct PartitionId
    {
        /// <summary>
        ///  Maximum value for Partition Id
        /// </summary>
        public const byte Maximum = 254;

        /// <summary>
        ///  Minimum value for Partition Id
        /// </summary>
        public const byte Minimum = 0;

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
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}