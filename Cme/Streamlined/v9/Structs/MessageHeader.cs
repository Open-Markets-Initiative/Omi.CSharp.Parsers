using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Message Header: Template ID and length of message root
/// </summary>

public partial class MessageHeader
{
    /// <summary>
    ///  Block Length
    /// </summary>
    public ushort BlockLength => Layout.BlockLength.Value;

    /// <summary>
    ///  Template Id
    /// </summary>
    public TemplateId TemplateId => Layout.TemplateId.Value;

    /// <summary>
    ///  Schema Id
    /// </summary>
    public ushort SchemaId => Layout.SchemaId.Value;

    /// <summary>
    ///  Version
    /// </summary>
    public ushort Version => Layout.Version.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BlockLength BlockLength;
        public TemplateId TemplateId;
        public SchemaId SchemaId;
        public Version Version;
    };
};
