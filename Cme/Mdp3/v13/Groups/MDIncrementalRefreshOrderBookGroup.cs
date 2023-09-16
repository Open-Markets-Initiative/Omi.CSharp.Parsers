using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Order Book Group: Number of entries in Market Data message
    /// </summary>

    public partial class MDIncrementalRefreshOrderBookGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            OrderIdOptional OrderIdOptional;
            MdOrderPriorityOptional MdOrderPriorityOptional;
            MdEntryPxOptional MdEntryPxOptional;
            MdDisplayQtyOptional MdDisplayQtyOptional;
            SecurityId SecurityId;
            MdUpdateAction MdUpdateAction;
            MdEntryTypeBook MdEntryTypeBook;
            Padding6 Padding6;
        };
    };
}