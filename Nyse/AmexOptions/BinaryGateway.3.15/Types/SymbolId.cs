using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Symbol Id: Identification number assigned to the security
    /// </summary>

    public struct SymbolId
    {
        /// <summary>
        ///  Size of Symbol Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Symbol Id value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Symbol Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Symbol Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Symbol Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}