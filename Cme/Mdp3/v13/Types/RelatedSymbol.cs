using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Related Symbol: Related instrument Symbol
    /// </summary>
    public struct RelatedSymbol
    {
        /// <summary>
        ///  Fix Tag for Related Symbol
        /// </summary>
        public const ushort FixTag = 1649;

        /// <summary>
        ///  Length of Related Symbol in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Read Related Symbol from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Related Symbol
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
        ///  Related Symbol as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}