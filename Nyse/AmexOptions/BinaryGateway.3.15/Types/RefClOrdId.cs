using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Ref Cl Ord Id: Unique ID of the message as assigned by the firm.
    /// </summary>

    public struct RefClOrdId
    {
        /// <summary>
        ///  Size of Ref Cl Ord Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Ref Cl Ord Id value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Ref Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write Ref Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Ref Cl Ord Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}