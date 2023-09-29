using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Floor Broker Firm Crd: Risk Entity – CRD of NYSE Floor Broker Firm.
    /// </summary>

    public struct FloorBrokerFirmCrd
    {
        /// <summary>
        ///  Size of Floor Broker Firm Crd in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Floor Broker Firm Crd value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Floor Broker Firm Crd
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Floor Broker Firm Crd
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Floor Broker Firm Crd as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}