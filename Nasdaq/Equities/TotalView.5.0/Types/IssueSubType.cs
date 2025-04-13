using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Issue Sub Type: Identifies the security sub-type for the issue as assigned by NASDAQ. See Appendix for allowable values.
/// </summary>

public unsafe struct IssueSubType
{
    /// <summary>
    ///  Size of Issue Sub Type underlying field in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Length of Issue Sub Type field
    /// </summary>
    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (Bytes[0] == (byte)' ') { return 0; }
            if (Bytes[1] == (byte)' ') { return 1; }

            return 2;
        }
    }

    /// <summary>
    ///  Issue Sub Type value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Issue Sub Type field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != (byte)' '; }
    }

    /// <summary>
    ///  Read Issue Sub Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(IssueSubType value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Issue Sub Type
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
    ///  Encode Issue Sub Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(string value)
    {
        var length = value.Length;
        Bytes[0] = length > 0 ? (byte)value[0] : (byte)' ';
        Bytes[1] = length > 1 ? (byte)value[1] : (byte)' ';
    }

    /// <summary>
    ///  Issue Sub Type as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}
