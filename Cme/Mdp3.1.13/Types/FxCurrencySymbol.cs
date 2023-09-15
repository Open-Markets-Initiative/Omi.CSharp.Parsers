using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Fx Currency Symbol: Base/Local. Denotes the currency pair in CCY1/CCY2 convention
    /// </summary>
    public struct FxCurrencySymbol
    {
        /// <summary>
        ///  Fix Tag for Fx Currency Symbol
        /// </summary>
        public const ushort FixTag = 37725;

        /// <summary>
        ///  Length of Fx Currency Symbol in bytes
        /// </summary>
        public const int Length = 7;

        /// <summary>
        ///  Read Fx Currency Symbol from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Fx Currency Symbol
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
        ///  Fx Currency Symbol as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}