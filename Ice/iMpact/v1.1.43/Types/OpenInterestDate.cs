using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Open Interest Date: The date Open Interest is effective for, in the format of YYYY-MM-DD.
    /// </summary>
    public unsafe struct OpenInterestDate
    {
        /// <summary>
        ///  Size of Open Interest Date underlying field in bytes
        /// </summary>
        public const int Size = 10;

        /// <summary>
        ///  Open Interest Date value
        /// </summary>
        public readonly DateTime Value
            => TryRead(out var value) ? value : default;

        /// <summary>
        ///  Does Open Interest Date field contain a value?
        /// </summary>
        public readonly bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Bytes[0] >= (byte)'0' && Bytes[0] <= (byte)'9' &&
                    Bytes[1] >= (byte)'0' && Bytes[1] <= (byte)'9' &&
                    Bytes[2] >= (byte)'0' && Bytes[2] <= (byte)'9' &&
                    Bytes[3] >= (byte)'0' && Bytes[3] <= (byte)'9' &&
                    Bytes[4] == (byte)'-' &&
                    Bytes[5] >= (byte)'0' && Bytes[5] <= (byte)'9' &&
                    Bytes[6] >= (byte)'0' && Bytes[6] <= (byte)'9' &&
                    Bytes[7] == (byte)'-' &&
                    Bytes[8] >= (byte)'0' && Bytes[8] <= (byte)'9' &&
                    Bytes[9] >= (byte)'0' && Bytes[9] <= (byte)'9';
            }
        }

        /// <summary>
        ///  Read Open Interest Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DateTime Decode()
        {
            var year = (Bytes[0] - (byte)'0') * 1000 + (Bytes[1] - (byte)'0') * 100 + (Bytes[2] - (byte)'0') * 10 + (Bytes[1] - (byte)'0');
            var month = (Bytes[5] - (byte)'0') * 10 + (Bytes[6] - (byte)'0');
            var day = (Bytes[8] - (byte)'0') * 10 + (Bytes[9] - (byte)'0');

            return new DateTime(year, month, day);
        }

        /// <summary>
        ///  Try Read Open Interest Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out DateTime value)
        {
            if (HasValue)
            {
                value = Decode();
                return true;
            }

            value = default;
            return false;
        }

        /// <summary>
        ///  Encode Open Interest Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int year, int month, int day)
        {
            Bytes[0] = (byte)((year / 1000) + '0');
            Bytes[1] = (byte)((year % 1000 / 100) + '0');
            Bytes[2] = (byte)((year % 100 / 10) + '0');
            Bytes[3] = (byte)((year % 10) + '0');
            Bytes[4] = (byte)'-';
            Bytes[5] = (byte)((month % 100 / 10) + '0');
            Bytes[6] = (byte)((month % 10) + '0');
            Bytes[7] = (byte)'-';
            Bytes[8] = (byte)((day % 100 / 10) + '0');
            Bytes[9] = (byte)((day % 10) + '0');
        }

        /// <summary>
        ///  Encode Open Interest Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(DateTime value)
            => Encode(value.Year, value.Month, value.Day);

        /// <summary>
        ///  Reset Open Interest Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            Bytes[0] = 0;
            Bytes[1] = 0;
            Bytes[2] = 0;
            Bytes[3] = 0;
            Bytes[4] = 0;
            Bytes[5] = 0;
            Bytes[6] = 0;
            Bytes[7] = 0;
            Bytes[8] = 0;
            Bytes[9] = 0;
        }

        /// <summary>
        ///  Open Interest Date as string
        /// </summary>
        public readonly override string ToString()
            => HasValue ? $"{Value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}