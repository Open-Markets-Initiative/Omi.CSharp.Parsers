using System.Runtime.CompilerServices;;

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
        ///  Length of Tot Num Reports in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Tot Num Reports
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Tot Num Reports
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}