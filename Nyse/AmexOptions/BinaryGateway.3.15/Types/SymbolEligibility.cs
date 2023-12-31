using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Symbol Eligibility: Session level permission to control order entry based on type of symbol.
    /// </summary>

    public struct SymbolEligibility
    {
        /// <summary>
        ///  Length of Symbol Eligibility in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Symbol Eligibility
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Symbol Eligibility
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Symbol Eligibility as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}