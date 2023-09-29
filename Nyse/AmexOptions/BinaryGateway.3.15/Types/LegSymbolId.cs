using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Leg Symbol Id: Identification number assigned to the security.
    /// </summary>

    public struct LegSymbolId
    {
        /// <summary>
        ///  Size of Leg Symbol Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Leg Symbol Id value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Leg Symbol Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Leg Symbol Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Leg Symbol Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}