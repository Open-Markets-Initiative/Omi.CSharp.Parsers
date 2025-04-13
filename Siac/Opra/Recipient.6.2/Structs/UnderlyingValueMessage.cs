using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Underlying Value Message
/// </summary>

public partial class UnderlyingValueMessage
{
    /// <summary>
    ///  Underlying Value Message Type
    /// </summary>
    public UnderlyingValueMessageType UnderlyingValueMessageType => Fields.UnderlyingValueMessageType.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public UnderlyingValueMessageType UnderlyingValueMessageType;
    };

    protected Layout Fields;
};
