using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Security Alt Id: Expanded instrument description. Will contain either ISIN or CUSIP
    /// </summary>
    public unsafe struct SecurityAltId
    {
        /// <summary>
        ///  Fix Tag for Security Alt Id
        /// </summary>
        public const ushort FixTag = 455;

        /// <summary>
        ///  Length of Security Alt Id in bytes
        /// </summary>
        public const int Size = 12;

        /// <summary>
        ///  Read Security Alt Id from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Security Alt Id
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
        ///  Security Alt Id as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}