using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Trade Entry I D u Int 32: Market Data Trade Entry ID
    /// </summary>

    public struct MdTradeEntryIDUInt32
    {
        /// <summary>
        ///  Fix Tag for Md Trade Entry I D u Int 32
        /// </summary>
        public const ushort FixTag = 37711;

        /// <summary>
        ///  Size of Md Trade Entry I D u Int 32 in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Md Trade Entry I D u Int 32 value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Md Trade Entry I D u Int 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Md Trade Entry I D u Int 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Md Trade Entry I D u Int 32 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}