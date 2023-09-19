using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Clearing Firm Exposed: Clearing number of CMTA of the Exposed side of the Cross order.  For CUBEs, this is the CUBE order.
    /// </summary>
    public unsafe struct ClearingFirmExposed
    {
        /// <summary>
        ///  Length of Clearing Firm Exposed in bytes
        /// </summary>
        public const int Size = 5;

        /// <summary>
        ///  Read Clearing Firm Exposed from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Clearing Firm Exposed
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
        ///  Clearing Firm Exposed as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}