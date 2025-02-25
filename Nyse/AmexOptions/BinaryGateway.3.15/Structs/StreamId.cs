using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Stream Id
/// </summary>

public partial class StreamId
{
    /// <summary>
    ///  32 bit session id
    /// </summary>
    public uint Sess => Layout.Sess.Value;

    /// <summary>
    ///  Id of stream within session
    /// </summary>
    public uint User => Layout.User.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Sess Sess;
        public User User;
    };
};
