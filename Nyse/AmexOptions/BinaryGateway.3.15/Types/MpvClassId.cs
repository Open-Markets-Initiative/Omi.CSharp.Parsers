using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Mpv Class Id: Identification number assigned to the MPVClass
    /// </summary>

    public struct MpvClassId
    {
        /// <summary>
        ///  Size of Mpv Class Id in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Mpv Class Id value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Mpv Class Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Mpv Class Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Mpv Class Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}