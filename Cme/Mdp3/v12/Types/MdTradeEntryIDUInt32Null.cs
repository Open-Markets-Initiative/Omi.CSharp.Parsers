using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Trade Entry I D u Int 32 Null: Market Data Trade entry ID
    /// </summary>

    public unsafe struct MdTradeEntryIDUInt32Null
    {
        /// <summary>
        ///  Fix Tag for Md Trade Entry I D u Int 32 Null
        /// </summary>
        public const ushort FixTag = 37711;

        /// <summary>
        ///  Length of Md Trade Entry I D u Int 32 Null in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Md Trade Entry I D u Int 32 Null
        /// </summary>
        public const uint NoValue = 4294967295;

        /// <summary>
        ///  Size of Md Trade Entry I D u Int 32 Null in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Md Trade Entry I D u Int 32 Null
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Md Trade Entry I D u Int 32 Null
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Md Trade Entry I D u Int 32 Null as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}