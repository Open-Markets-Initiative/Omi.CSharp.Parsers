using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Settl Type: For SPOTs will contain 0. For Fixed date NDFs will contain the value 'B'. For the standard NDFs tenors expressed using Dx, Mx, Wx, and Yx values, where 'x' does not denote business days, but calendar days
    /// </summary>
    public unsafe struct SettlType
    {
        /// <summary>
        ///  Fix Tag for Settl Type
        /// </summary>
        public const ushort FixTag = 63;

        /// <summary>
        ///  Size of Settl Type underlying field in bytes
        /// </summary>
        public const int Size = 3;

        /// <summary>
        ///  Read Settl Type from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Settl Type
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
        ///  Settl Type as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}