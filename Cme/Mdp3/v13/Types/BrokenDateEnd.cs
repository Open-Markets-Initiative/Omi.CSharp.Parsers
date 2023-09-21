using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Broken Date End: End date of a broken date period
    /// </summary>

    public unsafe struct BrokenDateEnd
    {
        /// <summary>
        ///  Fix Tag for Broken Date End
        /// </summary>
        public const ushort FixTag = 6741;

        /// <summary>
        ///  Sentinel null value for Broken Date End
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Broken Date End in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Broken Date End
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Try Read Broken Date End
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Broken Date End
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Set Broken Date End to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Broken Date End as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}