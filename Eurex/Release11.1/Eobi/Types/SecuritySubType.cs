using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Security Sub Type
    /// </summary>

    public struct SecuritySubType
    {
        /// <summary>
        ///  Maximum value for Security Sub Type
        /// </summary>
        public const int Maximum = 2147483647;

        /// <summary>
        ///  Minimum value for Security Sub Type
        /// </summary>
        public const int Minimum = -2147483647;

        /// <summary>
        ///  Size of Security Sub Type in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Security Sub Type value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying;

        /// <summary>
        ///  Write Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value;

        /// <summary>
        ///  Security Sub Type as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}