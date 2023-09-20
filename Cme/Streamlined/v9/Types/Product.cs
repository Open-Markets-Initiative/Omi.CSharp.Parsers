using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Product: Indicates the type of product the instrument is associated with in the message
    /// </summary>

    public struct Product
    {
        /// <summary>
        ///  Fix Tag for Product
        /// </summary>
        public const ushort FixTag = 460;

        /// <summary>
        ///  Size of Product in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Product
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Product
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Product as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}