using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Contract Symbol Extra: Extra contract symbol. Some contract symbols might contain more than 35 characters. Clients should append this field to ContractSymbol (Offset 11) to get the complete contract symbol.
    /// </summary>
    public struct ContractSymbolExtra
    {
        /// <summary>
        ///  Length of Contract Symbol Extra in bytes
        /// </summary>
        public const int Length = 35;

        /// <summary>
        ///  Read Contract Symbol Extra from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Contract Symbol Extra
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Length);

            for (var i = 0; i < end; i++)
            {
                Buffer[i] = (byte)value[i];
            }

            for (var i = end; i < Length; i++)
            {
                Buffer[i] = 0;
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
        internal unsafe fixed byte Buffer[Length];
    }
}