using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Instrument Guid: External unique instrument ID
    /// </summary>

    public unsafe struct InstrumentGuid
    {
        /// <summary>
        ///  Fix Tag for Instrument Guid
        /// </summary>
        public const ushort FixTag = 37513;

        /// <summary>
        ///  Length of Instrument Guid in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Sentinel null value for Instrument Guid
        /// </summary>
        public const ulong NoValue = 18446744073709551615;

        /// <summary>
        ///  Size of Instrument Guid in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Instrument Guid
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Instrument Guid
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Instrument Guid as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}