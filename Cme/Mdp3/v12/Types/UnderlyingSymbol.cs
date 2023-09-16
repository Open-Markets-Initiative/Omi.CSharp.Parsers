using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Underlying Symbol: Underlying Instrument Symbol (Contract Name)
    /// </summary>
    public struct UnderlyingSymbol
    {
        /// <summary>
        ///  Fix Tag for Underlying Symbol
        /// </summary>
        public const ushort FixTag = 311;

        /// <summary>
        ///  Length of Underlying Symbol in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Read Underlying Symbol from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Underlying Symbol
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
        ///  Underlying Symbol as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}