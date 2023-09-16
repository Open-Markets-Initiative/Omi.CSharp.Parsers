using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Risk User Crd: Risk User – CRD of the firm that owns the risk control represented by this message.
    /// </summary>

    public unsafe struct RiskUserCrd
    {
        /// <summary>
        ///  Length of Risk User Crd in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Risk User Crd
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Risk User Crd
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