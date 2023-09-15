using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Message Header: Template ID and length of message root
    /// </summary>

    public partial class MessageHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            BlockLength BlockLength;
            TemplateId TemplateId;
            SchemaId SchemaId;
            Version Version;
        };
    };
}