using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Schema Id:
    /// </summary>

    public unsafe struct SchemaId
    {
        /// <summary>
        ///  Length of Schema Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Schema Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Schema Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}