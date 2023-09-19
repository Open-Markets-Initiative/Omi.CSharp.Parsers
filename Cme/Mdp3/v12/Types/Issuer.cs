using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Issuer: Name of security issuer or the Legal Entity Identifier (LEI - the International ISO standard 17442)
    /// </summary>
    public unsafe struct Issuer
    {
        /// <summary>
        ///  Fix Tag for Issuer
        /// </summary>
        public const ushort FixTag = 106;

        /// <summary>
        ///  Length of Issuer in bytes
        /// </summary>
        public const int Size = 25;

        /// <summary>
        ///  Read Issuer from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Issuer
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
        ///  Issuer as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}