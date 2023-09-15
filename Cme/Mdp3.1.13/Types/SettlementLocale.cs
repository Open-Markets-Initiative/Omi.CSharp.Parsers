using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Settlement Locale: Settlement Locale. Optionally used to differentiate settlement location
    /// </summary>
    public struct SettlementLocale
    {
        /// <summary>
        ///  Fix Tag for Settlement Locale
        /// </summary>
        public const ushort FixTag = 37734;

        /// <summary>
        ///  Length of Settlement Locale in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Settlement Locale from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Settlement Locale
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
        ///  Settlement Locale as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}