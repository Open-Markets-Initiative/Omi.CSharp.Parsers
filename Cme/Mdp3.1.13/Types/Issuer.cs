using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Issuer: Name of security issuer or the Legal Entity Identifier (LEI - the International ISO standard 17442)
    /// </summary>
    public struct Issuer
    {
        /// <summary>
        ///  Fix Tag for Issuer
        /// </summary>
        public const ushort FixTag = 106;

        /// <summary>
        ///  Length of Issuer in bytes
        /// </summary>
        public const int Length = 25;

        /// <summary>
        ///  Read Issuer from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Issuer
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
        ///  Issuer as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}