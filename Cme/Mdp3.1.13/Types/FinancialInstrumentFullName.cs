using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Financial Instrument Full Name: Long name of the instrument
    /// </summary>
    public struct FinancialInstrumentFullName
    {
        /// <summary>
        ///  Fix Tag for Financial Instrument Full Name
        /// </summary>
        public const ushort FixTag = 2714;

        /// <summary>
        ///  Length of Financial Instrument Full Name in bytes
        /// </summary>
        public const int Length = 35;

        /// <summary>
        ///  Read Financial Instrument Full Name from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Financial Instrument Full Name
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Length);

            for (var i = 0; i < end; i++)
            {
                Buffer[i] = (byte)value[i];
            }

            for (var i = end; i < Length; i++)
            {
                Buffer[i] = 0;
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
        internal unsafe fixed byte Buffer[Length];
    }
}