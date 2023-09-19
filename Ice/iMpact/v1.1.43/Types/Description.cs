using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Description: The auction runs twice daily at 10:30am and 3:00pm London time.  The values disseminated via this field are: ‘GOLD_1030’, ‘GOLD_1500’
    /// </summary>
    public unsafe struct Description
    {
        /// <summary>
        ///  Length of Description in bytes
        /// </summary>
        public const int Size = 20;

        /// <summary>
        ///  Read Description from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Description
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
        ///  Description as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}