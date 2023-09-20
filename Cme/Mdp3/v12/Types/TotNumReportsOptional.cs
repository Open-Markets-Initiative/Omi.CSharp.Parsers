using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Tot Num Reports Optional: Total number of instruments in the Replay loop. Used on Replay Feed only
    /// </summary>

    public unsafe struct TotNumReportsOptional
    {
        /// <summary>
        ///  Fix Tag for Tot Num Reports Optional
        /// </summary>
        public const ushort FixTag = 911;

        /// <summary>
        ///  Length of Tot Num Reports Optional in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Tot Num Reports Optional
        /// </summary>
        public const uint NoValue = 4294967295;

        /// <summary>
        ///  Size of Tot Num Reports Optional in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Tot Num Reports Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Try Read Tot Num Reports Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out uint value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Tot Num Reports Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Set Tot Num Reports Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Tot Num Reports Optional as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}