using System;
using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Text 500: This general purpose text field could contain any post-trade instructions used by customers based on mutual understanding with their clearing firm. If incoming value is greater than max length then take the right most fifty bytes. No validation is done for valid values and this is a pass through to clearing. After any right justification if applicable the incoming value is flipped back in the execution report and also becomes an attribute of the order.
    /// </summary>
    public struct Text500
    {
        /// <summary>
        ///  Fix Tag for Text 500
        /// </summary>
        public const ushort FixTag = 58;

        /// <summary>
        ///  Length of Text 500 in bytes
        /// </summary>
        public const int Length = 500;

        /// <summary>
        ///  Read Text 500 from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Text 500
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
        ///  Text 500 as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}