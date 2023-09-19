using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Financial Instrument Full Name: Long name of the instrument
    /// </summary>
    public unsafe struct FinancialInstrumentFullName
    {
        /// <summary>
        ///  Fix Tag for Financial Instrument Full Name
        /// </summary>
        public const ushort FixTag = 2714;

        /// <summary>
        ///  Length of Financial Instrument Full Name in bytes
        /// </summary>
        public const int Size = 35;

        /// <summary>
        ///  Read Financial Instrument Full Name from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Financial Instrument Full Name
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
        ///  Financial Instrument Full Name as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}