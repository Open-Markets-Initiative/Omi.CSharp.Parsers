using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Incremental Refresh Volume: MDIncrementalRefreshVolume
    /// </summary>

    public partial class MdIncrementalRefreshVolume
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            Padding2 Padding2;
        };
    };
}