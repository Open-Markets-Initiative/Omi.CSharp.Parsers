using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Instrument Definition Spread Leg Groups: Number of Leg entries Block
    /// </summary>

    public partial class MDInstrumentDefinitionSpreadLegGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}