using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Alt Min Quote Life: MQL duration in number of microseconds applied to orders at AltMinPriceIncrement
    /// </summary>

    public unsafe struct AltMinQuoteLife
    {
        /// <summary>
        ///  Fix Tag for Alt Min Quote Life
        /// </summary>
        public const ushort FixTag = 37738;

        /// <summary>
        ///  Sentinel null value for Alt Min Quote Life
        /// </summary>
        public const uint NoValue = 4294967295;

        /// <summary>
        ///  Size of Alt Min Quote Life in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Alt Min Quote Life
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Try Read Alt Min Quote Life
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out uint value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Alt Min Quote Life
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Set Alt Min Quote Life to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Alt Min Quote Life as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}