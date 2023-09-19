using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Strike Currency: Currency in which the StrikePrice is denominated
    /// </summary>
    public unsafe struct StrikeCurrency
    {
        /// <summary>
        ///  Fix Tag for Strike Currency
        /// </summary>
        public const ushort FixTag = 947;

        /// <summary>
        ///  Length of Strike Currency in bytes
        /// </summary>
        public const int Size = 3;

        /// <summary>
        ///  Read Strike Currency from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Strike Currency
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Size);

            for (var i = 0; i < end; i++)
            {
                Bytes[i] = (byte)value[i];
            }

            for (var i = end; i < Size; i++)
            {
                Bytes[i] = 0;
            }
        }

        /// <summary>
        ///  Strike Currency as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}