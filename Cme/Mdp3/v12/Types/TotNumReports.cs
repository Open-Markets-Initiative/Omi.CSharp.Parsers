using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Tot Num Reports: Total number of messages replayed in the loop
    /// </summary>

    public unsafe struct TotNumReports
    {
        /// <summary>
        ///  Fix Tag for Tot Num Reports
        /// </summary>
        public const ushort FixTag = 911;

        /// <summary>
        ///  Size of Tot Num Reports in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Tot Num Reports
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Tot Num Reports
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Tot Num Reports as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}