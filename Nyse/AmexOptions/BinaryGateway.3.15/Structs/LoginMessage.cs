using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Login Message
/// </summary>

public partial class LoginMessage
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
    ///  User password in plain text
    /// </summary>
    public string Password => Layout.Password.Value;

    /// <summary>
    ///  Market Identifier Code (MIC) of the connected market.
    /// </summary>
    public string Mic => Layout.Mic.Value;

    /// <summary>
    ///  Protocol version, should be 1.1
    /// </summary>
    public string Version => Layout.Version.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MsgHeader MsgHeader;
        public Username Username;
        public Password Password;
        public Mic Mic;
        public Version Version;
    };
};
