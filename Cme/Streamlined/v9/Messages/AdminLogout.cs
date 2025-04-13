using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Admin Logout: AdminLogout
/// </summary>

public partial class AdminLogout
{
    /// <summary>
    ///  Free format text string. May include logout confirmation or reason for logout
    /// </summary>
    public string Text => Fields.Text.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Text Text;
    };

    protected Layout Fields;
};
