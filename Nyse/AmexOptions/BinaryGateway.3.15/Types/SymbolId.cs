using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Symbol Id: Identification number assigned to the security
    /// </summary>

    public unsafe struct SymbolId
    {
        /// <summary>
        ///  Length of Symbol Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Symbol Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Symbol Id
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