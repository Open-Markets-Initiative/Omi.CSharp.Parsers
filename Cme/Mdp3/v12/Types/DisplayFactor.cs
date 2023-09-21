using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Display Factor: Contains the multiplier to convert the CME Globex display price to the conventional price
    /// </summary>

    public unsafe struct DisplayFactor
    {
        /// <summary>
        ///  Fix Tag for Display Factor
        /// </summary>
        public const ushort FixTag = 9787;

        /// <summary>
        ///  Decimal place factor for Display Factor
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Size of Display Factor in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Display Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Display Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Display Factor as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}