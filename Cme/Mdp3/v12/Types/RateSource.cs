using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Rate Source: Fixing Rate Source
    /// </summary>
    public struct RateSource
    {
        /// <summary>
        ///  Fix Tag for Rate Source
        /// </summary>
        public const ushort FixTag = 1446;

        /// <summary>
        ///  Length of Rate Source in bytes
        /// </summary>
        public const int Length = 12;

        /// <summary>
        ///  Read Rate Source from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Rate Source
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
        ///  Rate Source as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}