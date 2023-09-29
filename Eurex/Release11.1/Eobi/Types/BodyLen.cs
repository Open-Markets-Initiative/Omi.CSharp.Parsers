using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Body Len
    /// </summary>

    public struct BodyLen
    {
        /// <summary>
        ///  Size of Body Len in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Body Len value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Body Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Body Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Body Len as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}