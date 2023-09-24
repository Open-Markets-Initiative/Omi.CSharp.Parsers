using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  End Date: End date of a financing deal, i.e. the date the seller reimburses the buyer and takes back control of the collateral
    /// </summary>

    public unsafe struct EndDate
    {
        /// <summary>
        ///  Fix Tag for End Date
        /// </summary>
        public const ushort FixTag = 917;

        /// <summary>
        ///  Sentinel null value for End Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of End Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read End Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Try Read End Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write End Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Set End Date to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  End Date as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}