using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Text Message Extra Fld: Extra field for text message when TextMessage field is not big enough. This should be appended to TextMessage if it is not empty.
    /// </summary>
    public unsafe struct TextMessageExtraFld
    {
        /// <summary>
        ///  Length of Text Message Extra Fld in bytes
        /// </summary>
        public const int Size = 800;

        /// <summary>
        ///  Read Text Message Extra Fld from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Text Message Extra Fld
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Size);

            for (var i = 0; i < end; i++)
            {
                Bytes[i] = (byte)value[i];
            }

            for (var i = end; i < Size; i++)
            {
                Bytes[i] = 0;
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
        internal unsafe fixed byte Bytes[Size];
    }
}