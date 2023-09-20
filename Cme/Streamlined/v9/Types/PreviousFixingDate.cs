using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Previous Fixing Date: Issue date for one leg of a multi-issue trade. It is the previous fixing date on the float leg.
    /// </summary>

    public unsafe struct PreviousFixingDate
    {
        /// <summary>
        ///  Fix Tag for Previous Fixing Date
        /// </summary>
        public const ushort FixTag = 37501;

        /// <summary>
        ///  Length of Previous Fixing Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Sentinel null value for Previous Fixing Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Previous Fixing Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Previous Fixing Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Try Read Previous Fixing Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Previous Fixing Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Set Previous Fixing Date to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Previous Fixing Date as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}