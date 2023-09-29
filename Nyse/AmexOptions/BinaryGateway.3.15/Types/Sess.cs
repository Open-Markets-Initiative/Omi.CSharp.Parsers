using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Sess: 32 bit session id
    /// </summary>

    public struct Sess
    {
        /// <summary>
        ///  Size of Sess in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Sess value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Sess
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Sess
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Sess as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}