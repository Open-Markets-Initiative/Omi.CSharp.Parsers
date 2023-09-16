using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Group Id: User-defined takedown group. Applies to all Quote messages in repeating group.
    /// </summary>

    public unsafe struct GroupId
    {
        /// <summary>
        ///  Length of Group Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Group Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Group Id
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