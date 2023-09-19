using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Underlying Instrument Guid: Underlying Instrument GUID. Collateral security identifier in REF Data API services
    /// </summary>

    public unsafe struct UnderlyingInstrumentGuid
    {
        /// <summary>
        ///  Fix Tag for Underlying Instrument Guid
        /// </summary>
        public const ushort FixTag = 37519;

        /// <summary>
        ///  Size of Underlying Instrument Guid in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Underlying Instrument Guid
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Underlying Instrument Guid
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Underlying Instrument Guid as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}