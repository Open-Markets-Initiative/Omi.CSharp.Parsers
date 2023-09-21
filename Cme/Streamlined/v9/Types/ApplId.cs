using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Appl Id: This value indicates the channel ID as defined in the XML configuration file.
    /// </summary>

    public unsafe struct ApplId
    {
        /// <summary>
        ///  Fix Tag for Appl Id
        /// </summary>
        public const ushort FixTag = 1180;

        /// <summary>
        ///  Sentinel null value for Appl Id
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Appl Id in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Try Read Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Set Appl Id to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Appl Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}