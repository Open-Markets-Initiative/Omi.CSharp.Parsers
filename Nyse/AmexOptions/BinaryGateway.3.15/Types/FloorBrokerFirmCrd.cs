using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Floor Broker Firm Crd: Risk Entity – CRD of NYSE Floor Broker Firm.
    /// </summary>

    public unsafe struct FloorBrokerFirmCrd
    {
        /// <summary>
        ///  Size of Floor Broker Firm Crd in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Floor Broker Firm Crd
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Floor Broker Firm Crd
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Floor Broker Firm Crd as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}