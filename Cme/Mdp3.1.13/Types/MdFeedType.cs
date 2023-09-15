using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Md Feed Type: Describes a class of service for a given data feed. GBX- Real Book, GBI-Implied Book
    /// </summary>
    public struct MdFeedType
    {
        /// <summary>
        ///  Fix Tag for Md Feed Type
        /// </summary>
        public const ushort FixTag = 1022;

        /// <summary>
        ///  Length of Md Feed Type in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Read Md Feed Type from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Md Feed Type
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
        ///  Md Feed Type as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}