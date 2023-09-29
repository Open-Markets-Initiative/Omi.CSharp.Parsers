using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Cross Id: Unique ID of the Cross as assigned by the firm.
    /// </summary>

    public struct CrossId
    {
        /// <summary>
        ///  Size of Cross Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Cross Id value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Cross Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}