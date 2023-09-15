using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Fix Rate Local Time: Fixing Rate Local Time, denoted in HH:MM:SS format
    /// </summary>
    public struct FixRateLocalTime
    {
        /// <summary>
        ///  Fix Tag for Fix Rate Local Time
        /// </summary>
        public const ushort FixTag = 37726;

        /// <summary>
        ///  Length of Fix Rate Local Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Fix Rate Local Time from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Fix Rate Local Time
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
        ///  Fix Rate Local Time as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}