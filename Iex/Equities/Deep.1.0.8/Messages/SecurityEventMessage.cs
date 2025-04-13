using System.Runtime.InteropServices;

namespace Iex.Deep;

/// <summary>
///  Security Event Message: The Security Event Message is used to indicate events that apply to a security
/// </summary>

public partial class SecurityEventMessage
{
    /// <summary>
    ///  Security event identifier
    /// </summary>
    public SecurityEvent SecurityEvent => Fields.SecurityEvent.Value;

    /// <summary>
    ///  Time stamp of the system event
    /// </summary>
    public DateTime Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Security identifier
    /// </summary>
    public string Symbol => Fields.Symbol.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityEvent SecurityEvent;
        public Timestamp Timestamp;
        public Symbol Symbol;
    };

    protected Layout Fields;
};
