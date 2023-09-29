using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Template Id
    /// </summary>

    public struct TemplateId
    {
        /// <summary>
        ///  Size of Template Id in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Template Id value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Template Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Template Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Template Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}