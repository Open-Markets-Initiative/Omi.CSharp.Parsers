using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Non Disclosed Trade Volume
    /// </summary>

    public unsafe struct NonDisclosedTradeVolume
    {
        /// <summary>
        ///  Decimal place factor for Non Disclosed Trade Volume
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Non Disclosed Trade Volume in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Non Disclosed Trade Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Non Disclosed Trade Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Non Disclosed Trade Volume as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}