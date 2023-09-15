using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Security Group: Security Group
    /// </summary>
    public struct SecurityGroup
    {
        /// <summary>
        ///  Fix Tag for Security Group
        /// </summary>
        public const ushort FixTag = 1151;

        /// <summary>
        ///  Length of Security Group in bytes
        /// </summary>
        public const int Length = 6;

        /// <summary>
        ///  Read Security Group from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Security Group
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
        ///  Security Group as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}