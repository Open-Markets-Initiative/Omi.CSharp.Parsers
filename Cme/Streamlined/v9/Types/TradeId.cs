using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Trade Id: Unique Trade Entry ID per Instrument  and Trading Date
/// </summary>

public struct TradeId
{
    /// <summary>
    ///  Fix Tag for Trade Id
    /// </summary>
    public const ushort FixTag = 1003;

    /// <summary>
    ///  Size of Trade Id in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Trade Id value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => Underlying;

    /// <summary>
    ///  Write Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = value;

    /// <summary>
    ///  Trade Id as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}
