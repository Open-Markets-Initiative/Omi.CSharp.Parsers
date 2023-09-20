using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Fix Rate Local Time Zone: Fixing Rate Local Time Zone corresponding to Fixing Local Time.
    /// </summary>
    public unsafe struct FixRateLocalTimeZone
    {
        /// <summary>
        ///  Fix Tag for Fix Rate Local Time Zone
        /// </summary>
        public const ushort FixTag = 37727;

        /// <summary>
        ///  Size of Fix Rate Local Time Zone underlying field in bytes
        /// </summary>
        public const int Size = 20;

        /// <summary>
        ///  Read Fix Rate Local Time Zone from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Fix Rate Local Time Zone
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
        ///  Fix Rate Local Time Zone as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}