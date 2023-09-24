using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Country Of Issue: Country of Origin, ISO alpha-2 country code
    /// </summary>
    public unsafe struct CountryOfIssue
    {
        /// <summary>
        ///  Fix Tag for Country Of Issue
        /// </summary>
        public const ushort FixTag = 470;

        /// <summary>
        ///  Size of Country Of Issue underlying field in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Length of Country Of Issue field
        /// </summary>
        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Bytes[0] == 0) { return 0; }
                if (Bytes[1] == 0) { return 1; }

                return 2;
            }
        }

        /// <summary>
        ///  Country Of Issue value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Country Of Issue field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != 0; }
        }

        /// <summary>
        ///  Read Country Of Issue
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(CountryOfIssue value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Country Of Issue
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
        ///  Encode Country Of Issue
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(string value)
        {
            var length = value.Length;
            Bytes[0] = length > 0 ? (byte)value[0] : (byte)0;
            Bytes[1] = length > 1 ? (byte)value[1] : (byte)0;
        }

        /// <summary>
        ///  Country Of Issue as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}