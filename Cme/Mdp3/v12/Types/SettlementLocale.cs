using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Settlement Locale: Settlement Locale. Optionally used to differentiate settlement location
    /// </summary>
    public unsafe struct SettlementLocale
    {
        /// <summary>
        ///  Fix Tag for Settlement Locale
        /// </summary>
        public const ushort FixTag = 37734;

        /// <summary>
        ///  Length of Settlement Locale in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Settlement Locale from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Settlement Locale
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
        ///  Settlement Locale as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}