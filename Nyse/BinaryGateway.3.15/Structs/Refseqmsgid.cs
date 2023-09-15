using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Refseqmsgid
    /// </summary>

    public partial class Refseqmsgid
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StreamId StreamId;
            Seq Seq;
        };
    };
}