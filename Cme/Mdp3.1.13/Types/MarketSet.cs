using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Market Set: Market Set defines the bilateral relationship and Self Match Prevention configuration for eligible markets
    /// </summary>
    public struct MarketSet
    {
        /// <summary>
        ///  Fix Tag for Market Set
        /// </summary>
        public const ushort FixTag = 37722;

        /// <summary>
        ///  Length of Market Set in bytes
        /// </summary>
        public const int Length = 6;

        /// <summary>
        ///  Read Market Set from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Market Set
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
        ///  Market Set as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}