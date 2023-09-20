using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Working Away From Display: 0 = Working Price is equal to Display Price 1 = Working Price is different from Display Price
    /// </summary>

    public struct WorkingAwayFromDisplay
    {
        /// <summary>
        ///  Length of Working Away From Display in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Working Away From Display
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Working Away From Display
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Working Away From Display as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}