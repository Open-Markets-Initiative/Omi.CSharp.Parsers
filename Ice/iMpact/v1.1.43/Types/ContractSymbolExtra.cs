using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Contract Symbol Extra: Extra contract symbol. Some contract symbols might contain more than 35 characters. Clients should append this field to ContractSymbol (Offset 11) to get the complete contract symbol.
    /// </summary>
    public unsafe struct ContractSymbolExtra
    {
        /// <summary>
        ///  Size of Contract Symbol Extra underlying field in bytes
        /// </summary>
        public const int Size = 35;

        /// <summary>
        ///  Read Contract Symbol Extra from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Contract Symbol Extra
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
        ///  Contract Symbol Extra as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}