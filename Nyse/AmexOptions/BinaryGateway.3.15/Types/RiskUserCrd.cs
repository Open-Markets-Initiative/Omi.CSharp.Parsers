using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Risk User Crd: Risk User – CRD of the firm that owns the risk control represented by this message.
    /// </summary>

    public struct RiskUserCrd
    {
        /// <summary>
        ///  Size of Risk User Crd in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Risk User Crd value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Risk User Crd
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Risk User Crd
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Risk User Crd as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}