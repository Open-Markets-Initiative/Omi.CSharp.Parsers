using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Fx Currency Symbol: Base/Local. Denotes the currency pair in CCY1/CCY2 convention
    /// </summary>
    public unsafe struct FxCurrencySymbol
    {
        /// <summary>
        ///  Fix Tag for Fx Currency Symbol
        /// </summary>
        public const ushort FixTag = 37725;

        /// <summary>
        ///  Length of Fx Currency Symbol in bytes
        /// </summary>
        public const int Size = 7;

        /// <summary>
        ///  Read Fx Currency Symbol from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Fx Currency Symbol
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
        ///  Fx Currency Symbol as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}