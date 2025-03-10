namespace Iex.Tops;

using System.Runtime.CompilerServices;

/// <summary>
///  Security Directory Flags: Bitfield
/// </summary>

public sealed class SecurityDirectoryFlags
{
    /// <summary>
    ///  Test Security
    /// </summary>
    public const byte TestSecurity = 1 << 0;

    /// <summary>
    ///  When Issued
    /// </summary>
    public const byte WhenIssued = 1 << 1;

    /// <summary>
    ///  Etp
    /// </summary>
    public const byte Etp = 1 << 2;

    /// <summary>
    ///  Unused 5
    /// </summary>
    public const byte Unused5 = 1 << 3;

    /// <summary>
    ///  Length of Security Directory Flags in bytes
    /// </summary>
    public const int Length = 1;
}
