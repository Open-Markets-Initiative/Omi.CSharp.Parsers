using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Broken Date Guid: External unique broken date Instrument ID
    /// </summary>

    public unsafe struct BrokenDateGuid
    {
        /// <summary>
        ///  Fix Tag for Broken Date Guid
        /// </summary>
        public const ushort FixTag = 39031;

        /// <summary>
        ///  Size of Broken Date Guid in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Broken Date Guid
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Broken Date Guid
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Broken Date Guid as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}