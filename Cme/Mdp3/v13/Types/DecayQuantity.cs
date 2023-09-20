using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Decay Quantity: Indicates the quantity that a contract will decay daily by once the decay start date is reached
    /// </summary>

    public unsafe struct DecayQuantity
    {
        /// <summary>
        ///  Fix Tag for Decay Quantity
        /// </summary>
        public const ushort FixTag = 5818;

        /// <summary>
        ///  Length of Decay Quantity in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Decay Quantity
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Decay Quantity in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Decay Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Try Read Decay Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Decay Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Set Decay Quantity to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Decay Quantity as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}