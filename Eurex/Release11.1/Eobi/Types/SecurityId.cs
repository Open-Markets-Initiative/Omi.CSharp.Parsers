using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Security Id
    /// </summary>

    public struct SecurityId
    {
        /// <summary>
        ///  Maximum value for Security Id
        /// </summary>
        public const long Maximum = 9223372036854775807;

        /// <summary>
        ///  Minimum value for Security Id
        /// </summary>
        public const long Minimum = -9223372036854775807;

        /// <summary>
        ///  Size of Security Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Security Id value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying;

        /// <summary>
        ///  Write Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value;

        /// <summary>
        ///  Security Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}