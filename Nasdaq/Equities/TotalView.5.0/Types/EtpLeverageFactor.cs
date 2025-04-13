using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Etp Leverage Factor: Tracks the integral relationship of the ETP to the underlying index.   Example: If the underlying Index increases by a value of 1 and the ETP’s Leverage factor is 3, indicates the ETF will increase/decrease (see Inverse) by 3. Note: Leverage Factor of 1 indicates the ETP is NOT leveraged. This field is used for LULD Tier I price band calculation purposes.
/// </summary>

public struct EtpLeverageFactor
{
    /// <summary>
    ///  Size of Etp Leverage Factor in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Etp Leverage Factor value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Etp Leverage Factor
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Etp Leverage Factor
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Etp Leverage Factor as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}
