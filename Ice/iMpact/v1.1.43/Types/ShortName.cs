using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Short Name: The short name date of the Marker/Index.  For example “Morn5Min”
    /// </summary>
    public unsafe struct ShortName
    {
        /// <summary>
        ///  Size of Short Name underlying field in bytes
        /// </summary>
        public const int Size = 30;

        /// <summary>
        ///  Read Short Name from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Short Name
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
        ///  Short Name as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}