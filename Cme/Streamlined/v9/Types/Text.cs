using System;
using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Text: Free format text string. May include logout confirmation or reason for logout
    /// </summary>
    public struct Text
    {
        /// <summary>
        ///  Fix Tag for Text
        /// </summary>
        public const ushort FixTag = 58;

        /// <summary>
        ///  Length of Text in bytes
        /// </summary>
        public const int Length = 180;

        /// <summary>
        ///  Read Text from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Text
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
        ///  Text as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}