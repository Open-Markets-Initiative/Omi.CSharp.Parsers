using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Underlying Product: Product complex
/// </summary>

public struct UnderlyingProduct
{
    /// <summary>
    ///  Fix Tag for Underlying Product
    /// </summary>
    public const ushort FixTag = 462;

    /// <summary>
    ///  Length of Underlying Product in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Underlying Product
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Underlying Product
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Underlying Product as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}
