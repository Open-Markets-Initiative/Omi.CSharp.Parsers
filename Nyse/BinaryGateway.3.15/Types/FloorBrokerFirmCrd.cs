using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Floor Broker Firm Crd: Risk Entity – CRD of NYSE Floor Broker Firm.
    /// </summary>

    public unsafe struct FloorBrokerFirmCrd
    {
        /// <summary>
        ///  Length of Floor Broker Firm Crd in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Floor Broker Firm Crd
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Floor Broker Firm Crd
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}