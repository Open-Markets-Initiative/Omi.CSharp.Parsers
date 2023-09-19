using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Trade Entry I D u Int 32: Market Data Trade Entry ID
    /// </summary>

    public unsafe struct MdTradeEntryIDUInt32
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
        ///  Read Md Trade Entry I D u Int 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Md Trade Entry I D u Int 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Md Trade Entry I D u Int 32 as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}