using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Number Of Orders: The total number of real orders per instrument that participated in a match step within a match event
/// </summary>

public struct NumberOfOrders
{
    /// <summary>
    ///  Fix Tag for Number Of Orders
    /// </summary>
    public const ushort FixTag = 346;

    /// <summary>
    ///  Sentinel null value for Number Of Orders
    /// </summary>
    public const int NoValue = 2147483647;

    /// <summary>
    ///  Size of Number Of Orders in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Number Of Orders value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Does Number Of Orders field contain a value?
    /// </summary>
    public readonly bool HasValue
        => Underlying != NoValue;

    /// <summary>
    ///  Read Number Of Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => Underlying;

    /// <summary>
    ///  Try Read Number Of Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool TryRead(out int value)
    {
        value = Decode();
        return HasValue;
    }

    /// <summary>
    ///  Write Number Of Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = value;

    /// <summary>
    ///  Set Number Of Orders to unused
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Reset()
        => Encode(NoValue);

    /// <summary>
    ///  Number Of Orders as string
    /// </summary>
    public readonly override string ToString()
        => TryRead(out var value) ? $"{value}" : "Not Applicable";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}
