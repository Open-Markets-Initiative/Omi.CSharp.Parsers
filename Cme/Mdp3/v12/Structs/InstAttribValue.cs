using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Inst Attrib Value: InstAttribValue bit set
    /// </summary>

    public partial class InstAttribValue
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Reserved4 Reserved4;
            HedgeInstrument HedgeInstrument;
            EfixInstrument EfixInstrument;
            MtfRegulated MtfRegulated;
            SefRegulated SefRegulated;
            IsAoNInstrument IsAoNInstrument;
            InvertedBook InvertedBook;
            VariableCabEligible VariableCabEligible;
            TriangulationEligible TriangulationEligible;
            ImpliedMatchingEligibility ImpliedMatchingEligibility;
            GtOrdersEligibility GtOrdersEligibility;
            DailyProductEligibility DailyProductEligibility;
            VariableProductEligibility VariableProductEligibility;
            DecayingProductEligibility DecayingProductEligibility;
            ZeroPriceOutrightEligible ZeroPriceOutrightEligible;
            RfqCrossEligible RfqCrossEligible;
            VolatilityQuotedOption VolatilityQuotedOption;
            IsFractional IsFractional;
            NegativePriceOutrightEligible NegativePriceOutrightEligible;
            NegativeStrikeEligible NegativeStrikeEligible;
            ILinkIndicativeMassQuotingEligible ILinkIndicativeMassQuotingEligible;
            OtcEligible OtcEligible;
            EfrEligible EfrEligible;
            EfsEligible EfsEligible;
            EbfEligible EbfEligible;
            EfpEligible EfpEligible;
            BlockTradeEligible BlockTradeEligible;
            OrderCrossEligible OrderCrossEligible;
            ElectronicMatchEligible ElectronicMatchEligible;
        };
    };
}