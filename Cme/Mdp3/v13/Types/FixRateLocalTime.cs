using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Fix Rate Local Time: Fixing Rate Local Time, denoted in HH:MM:SS format
    /// </summary>
    public unsafe struct FixRateLocalTime
    {
        /// <summary>
        ///  Fix Tag for Fix Rate Local Time
        /// </summary>
        public const ushort FixTag = 37726;

        /// <summary>
        ///  Length of Fix Rate Local Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Fix Rate Local Time from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Fix Rate Local Time
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
        ///  Fix Rate Local Time as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}