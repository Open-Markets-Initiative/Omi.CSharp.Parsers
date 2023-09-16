using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Text Message Extra Fld: Extra field for text message when TextMessage field is not big enough. This should be appended to TextMessage if it is not empty.
    /// </summary>
    public struct TextMessageExtraFld
    {
        /// <summary>
        ///  Length of Text Message Extra Fld in bytes
        /// </summary>
        public const int Length = 800;

        /// <summary>
        ///  Read Text Message Extra Fld from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Text Message Extra Fld
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
        ///  Text Message Extra Fld as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}