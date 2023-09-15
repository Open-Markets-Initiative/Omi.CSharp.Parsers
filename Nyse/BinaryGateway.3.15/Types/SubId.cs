using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Sub Id: Customer defined – Applies to all Quote messages in repeating group.
    /// </summary>
    public struct SubId
    {
        /// <summary>
        ///  Length of Sub Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Sub Id from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Sub Id
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
        ///  Sub Id as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}