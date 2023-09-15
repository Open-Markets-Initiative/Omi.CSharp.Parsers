using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Seqmsgid
    /// </summary>

    public partial class Seqmsgid
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StreamId StreamId;
            Seq Seq;
        };
    };
}