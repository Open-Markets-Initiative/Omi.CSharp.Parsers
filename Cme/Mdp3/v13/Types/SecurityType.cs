using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Security Type: Security Type
    /// </summary>
    public unsafe struct SecurityType
    {
        /// <summary>
        ///  Fix Tag for Security Type
        /// </summary>
        public const ushort FixTag = 167;

        /// <summary>
        ///  Size of Security Type underlying field in bytes
        /// </summary>
        public const int Size = 6;

        /// <summary>
        ///  Length of Security Type field
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
                if (Bytes[4] == 0) { return 4; }
                if (Bytes[5] == 0) { return 5; }

                return 6;
            }
        }

        /// <summary>
        ///  Does Security Type field contain a value?
        /// </summary>
        public bool HasValue
            => Bytes[0] != 0;

        /// <summary>
        ///  Read Security Type from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Length); }
        }

        /// <summary>
        ///  Try Read Security Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out string value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Encode Security Type
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
        ///  Security Type as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}