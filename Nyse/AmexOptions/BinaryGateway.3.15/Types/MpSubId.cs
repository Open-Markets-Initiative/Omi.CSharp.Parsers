using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Mp Sub Id: Customer defined – identifies specific entity/trading desk of customer firm.
    /// </summary>
    public unsafe struct MpSubId
    {
        /// <summary>
        ///  Size of Mp Sub Id underlying field in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Length of Mp Sub Id field
        /// </summary>
        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Bytes[0] == 0) { return 0; }
                if (Bytes[1] == 0) { return 1; }
                if (Bytes[2] == 0) { return 2; }
                if (Bytes[3] == 0) { return 3; }

                return 4;
            }
        }

        /// <summary>
        ///  Does Mp Sub Id field contain a value?
        /// </summary>
        public bool HasValue
            => Bytes[0] != 0;

        /// <summary>
        ///  Read Mp Sub Id from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Length); }
        }

        /// <summary>
        ///  Try Read Mp Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out string value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Encode Mp Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(string value)
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
        ///  Mp Sub Id as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}