using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Underlying Security Alt Id: Underlying Alternate Security identifier value as qualified by Tag 305-UnderlyingSecuityAltIDSource (e.g. CUSIP, ISIN, etc). For Repo special will contain underlying CUSIP or ISIN. For GC Repo may contain a synthetic CUSIP or ISIN representing a basket
    /// </summary>
    public unsafe struct UnderlyingSecurityAltId
    {
        /// <summary>
        ///  Fix Tag for Underlying Security Alt Id
        /// </summary>
        public const ushort FixTag = 458;

        /// <summary>
        ///  Length of Underlying Security Alt Id in bytes
        /// </summary>
        public const int Size = 12;

        /// <summary>
        ///  Read Underlying Security Alt Id from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Underlying Security Alt Id
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
        ///  Underlying Security Alt Id as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}