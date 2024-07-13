using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Opt Attribute
    /// </summary>

    public struct OptAttribute
    {
        /// <summary>
        ///  Maximum value for Opt Attribute
        /// </summary>
        public const uint Maximum = 4294967294;

        /// <summary>
        ///  Minimum value for Opt Attribute
        /// </summary>
        public const uint Minimum = 0;

        /// <summary>
        ///  Size of Opt Attribute in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Opt Attribute value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Opt Attribute
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Opt Attribute
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Opt Attribute as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}