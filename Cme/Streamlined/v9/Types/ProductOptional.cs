using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Product Optional: One Byte Fixed Width Integer
    /// </summary>

    public struct ProductOptional
    {
        /// <summary>
        ///  Fix Tag for Product Optional
        /// </summary>
        public const ushort FixTag = 460;

        /// <summary>
        ///  Length of Product Optional in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Product Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Product Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Product Optional as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}