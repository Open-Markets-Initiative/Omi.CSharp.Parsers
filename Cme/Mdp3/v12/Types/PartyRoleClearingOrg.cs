using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Party Role Clearing Org: Clearing organization
    /// </summary>
    public unsafe struct PartyRoleClearingOrg
    {
        /// <summary>
        ///  Fix Tag for Party Role Clearing Org
        /// </summary>
        public const ushort FixTag = 9736;

        /// <summary>
        ///  Size of Party Role Clearing Org underlying field in bytes
        /// </summary>
        public const int Size = 5;

        /// <summary>
        ///  Read Party Role Clearing Org from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Party Role Clearing Org
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
        ///  Party Role Clearing Org as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}