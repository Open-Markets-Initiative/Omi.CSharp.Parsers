using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Feed Type: Describes a class of service for a given data feed. GBX- Real Book, GBI-Implied Book
    /// </summary>
    public unsafe struct MdFeedType
    {
        /// <summary>
        ///  Fix Tag for Md Feed Type
        /// </summary>
        public const ushort FixTag = 1022;

        /// <summary>
        ///  Size of Md Feed Type underlying field in bytes
        /// </summary>
        public const int Size = 3;

        /// <summary>
        ///  Length of Md Feed Type field
        /// </summary>
        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Bytes[0] == 0) { return 0; }
                if (Bytes[1] == 0) { return 1; }
                if (Bytes[2] == 0) { return 2; }

                return 3;
            }
        }

        /// <summary>
        ///  Md Feed Type value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Md Feed Type field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != 0; }
        }

        /// <summary>
        ///  Read Md Feed Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(MdFeedType value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Md Feed Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out string value)
        {
            if (HasValue)
            {
                value = Decode(this);
                return true;
            }

            value = string.Empty;
            return false;
        }

        /// <summary>
        ///  Encode Md Feed Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(string value)
        {
            var length = value.Length;
            Bytes[0] = length > 0 ? (byte)value[0] : (byte)0;
            Bytes[1] = length > 1 ? (byte)value[1] : (byte)0;
            Bytes[2] = length > 2 ? (byte)value[2] : (byte)0;
        }

        /// <summary>
        ///  Md Feed Type as string
        /// </summary>
        public override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}