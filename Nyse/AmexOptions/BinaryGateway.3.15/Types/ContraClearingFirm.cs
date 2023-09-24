using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Contra Clearing Firm: Contra party clearing number of CMTA, if any - 5 digits.
    /// </summary>
    public unsafe struct ContraClearingFirm
    {
        /// <summary>
        ///  Size of Contra Clearing Firm underlying field in bytes
        /// </summary>
        public const int Size = 5;

        /// <summary>
        ///  Length of Contra Clearing Firm field
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

                return 5;
            }
        }

        /// <summary>
        ///  Contra Clearing Firm value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Contra Clearing Firm field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != 0; }
        }

        /// <summary>
        ///  Read Contra Clearing Firm
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(ContraClearingFirm value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Contra Clearing Firm
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
        ///  Encode Contra Clearing Firm
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(string value)
        {
            var length = value.Length;
            Bytes[0] = length > 0 ? (byte)value[0] : (byte)0;
            Bytes[1] = length > 1 ? (byte)value[1] : (byte)0;
            Bytes[2] = length > 2 ? (byte)value[2] : (byte)0;
            Bytes[3] = length > 3 ? (byte)value[3] : (byte)0;
            Bytes[4] = length > 4 ? (byte)value[4] : (byte)0;
        }

        /// <summary>
        ///  Contra Clearing Firm as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}