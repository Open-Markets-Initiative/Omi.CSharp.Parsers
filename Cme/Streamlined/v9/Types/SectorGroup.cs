using System.Runtime.CompilerServices;

namespace Cme.Streamlined;

/// <summary>
///  Sector Group: Group of related products. For e.g. High Yield, Cheese
/// </summary>

public unsafe struct SectorGroup
{
    /// <summary>
    ///  Fix Tag for Sector Group
    /// </summary>
    public const ushort FixTag = 37522;

    /// <summary>
    ///  Size of Sector Group underlying field in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Length of Sector Group field
    /// </summary>
    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (Bytes[0] == 0) { return 0; }
            if (Bytes[1] == 0) { return 1; }

            return 2;
        }
    }

    /// <summary>
    ///  Sector Group value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Sector Group field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != 0; }
    }

    /// <summary>
    ///  Read Sector Group
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(SectorGroup value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Sector Group
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryRead(out string value)
    {
        if (HasValue)
        {
            value = Decode(this);
            return true;
        }

        value = string.Empty;
        return false;
    }

    /// <summary>
    ///  Encode Sector Group
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(string value)
    {
        var length = value.Length;
        Bytes[0] = length > 0 ? (byte)value[0] : (byte)0;
        Bytes[1] = length > 1 ? (byte)value[1] : (byte)0;
    }

    /// <summary>
    ///  Sector Group as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}
