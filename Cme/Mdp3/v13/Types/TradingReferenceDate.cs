using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Trading Reference Date: Indicates session date corresponding to the settlement price in tag 1150-TradingReferencePrice
    /// </summary>

    public unsafe struct TradingReferenceDate
    {
        /// <summary>
        ///  Fix Tag for Trading Reference Date
        /// </summary>
        public const ushort FixTag = 5796;

        /// <summary>
        ///  Sentinel null value for Trading Reference Date
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Trading Reference Date in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Trading Reference Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return (ushort)pointer; }
        }

        /// <summary>
        ///  Try Read Trading Reference Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Trading Reference Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = value; }
        }

        /// <summary>
        ///  Set Trading Reference Date to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Trading Reference Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}