using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Login Response
/// </summary>

public partial class LoginResponse
{
    /// <summary>
    ///  Msg Header
    /// </summary>
    public string MsgHeader => Layout.MsgHeader.Value;

    /// <summary>
    ///  Unique identifier of the gateway session – SenderCompID.
    /// </summary>
    public string Username => Layout.Username.Value;

    /// <summary>
    ///  Pillar Status Code
    /// </summary>
    public Status Status => Layout.Status.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgHeader MsgHeader;
        public Username Username;
        public Status Status;
    };
};
