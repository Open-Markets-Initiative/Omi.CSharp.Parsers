using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Group Id: User-defined takedown group. Applies to all Quote messages in repeating group.
    /// </summary>

    public struct GroupId
    {
        /// <summary>
        ///  Size of Group Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Group Id value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Group Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Group Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Group Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}