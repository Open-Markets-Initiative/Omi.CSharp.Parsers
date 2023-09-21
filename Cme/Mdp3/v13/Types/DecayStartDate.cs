using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Decay Start Date: Indicates the date at which a decaying contract will begin to decay
    /// </summary>

    public unsafe struct DecayStartDate
    {
        /// <summary>
        ///  Fix Tag for Decay Start Date
        /// </summary>
        public const ushort FixTag = 5819;

        /// <summary>
        ///  Sentinel null value for Decay Start Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Decay Start Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Decay Start Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Try Read Decay Start Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Decay Start Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Set Decay Start Date to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Decay Start Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}