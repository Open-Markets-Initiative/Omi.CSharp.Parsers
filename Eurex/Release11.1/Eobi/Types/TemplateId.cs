using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Template Id
    /// </summary>

    public unsafe struct TemplateId
    {
        /// <summary>
        ///  Size of Template Id in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Template Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Write Template Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Template Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}