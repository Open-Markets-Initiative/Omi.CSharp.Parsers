using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Opt Attribute
    /// </summary>

    public unsafe struct OptAttribute
    {
        /// <summary>
        ///  Size of Opt Attribute in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Opt Attribute
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Opt Attribute
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Opt Attribute as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}