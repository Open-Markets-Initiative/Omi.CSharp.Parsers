using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Max No Of Substitutions: Max number of substitutions allowed. The value of 0 indicates that substitutions are not allowed
/// </summary>

public struct MaxNoOfSubstitutions
{
    /// <summary>
    ///  Fix Tag for Max No Of Substitutions
    /// </summary>
    public const ushort FixTag = 37715;

    /// <summary>
    ///  Length of Max No Of Substitutions in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Max No Of Substitutions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Max No Of Substitutions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Max No Of Substitutions as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}
