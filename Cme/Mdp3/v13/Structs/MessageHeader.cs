using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Message Header: Template ID and length of message root
/// </summary>

public partial class MessageHeader
{
    /// <summary>
    ///  Block Length
    /// </summary>
    public ushort BlockLength => Fields.BlockLength.Value;

    /// <summary>
    ///  Template Id
    /// </summary>
    public TemplateId TemplateId => Fields.TemplateId.Value;

    /// <summary>
    ///  Schema Id
    /// </summary>
    public ushort SchemaId => Fields.SchemaId.Value;

    /// <summary>
    ///  Version
    /// </summary>
    public ushort Version => Fields.Version.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BlockLength BlockLength;
        public TemplateId TemplateId;
        public SchemaId SchemaId;
        public Version Version;
    };

    protected Layout Fields;
};
