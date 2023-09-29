using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  User: Id of stream within session
    /// </summary>

    public struct User
    {
        /// <summary>
        ///  Size of User in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  User value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read User
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write User
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  User as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}