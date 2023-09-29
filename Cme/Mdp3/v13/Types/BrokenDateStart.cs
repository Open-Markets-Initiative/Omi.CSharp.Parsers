using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Broken Date Start: Start date of a broken date period
    /// </summary>

    public struct BrokenDateStart
    {
        /// <summary>
        ///  Fix Tag for Broken Date Start
        /// </summary>
        public const ushort FixTag = 6748;

        /// <summary>
        ///  Sentinel null value for Broken Date Start
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Broken Date Start in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Broken Date Start value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Broken Date Start
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Broken Date Start
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Broken Date Start
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Set Broken Date Start to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Broken Date Start as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}