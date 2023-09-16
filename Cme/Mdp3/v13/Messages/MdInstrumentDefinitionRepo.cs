using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Instrument Definition Repo: MDInstrumentDefinitionRepo
    /// </summary>

    public partial class MdInstrumentDefinitionRepo
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MatchEventIndicator MatchEventIndicator;
            TotNumReportsOptional TotNumReportsOptional;
            SecurityUpdateAction SecurityUpdateAction;
            LastUpdateTime LastUpdateTime;
            MdSecurityTradingStatus MdSecurityTradingStatus;
            ApplId ApplId;
            MarketSegmentId MarketSegmentId;
            UnderlyingProduct UnderlyingProduct;
            SecurityExchange SecurityExchange;
            SecurityGroup SecurityGroup;
            Asset Asset;
            Symbol Symbol;
            SecurityId SecurityId;
            SecurityType SecurityType;
            CfiCode CfiCode;
            Currency Currency;
            SettlCurrency SettlCurrency;
            MatchAlgorithm MatchAlgorithm;
            MinTradeVol MinTradeVol;
            MaxTradeVol MaxTradeVol;
            MinPriceIncrement MinPriceIncrement;
            DisplayFactor DisplayFactor;
            UnitOfMeasure UnitOfMeasure;
            UnitOfMeasureQty UnitOfMeasureQty;
            TradingReferencePrice TradingReferencePrice;
            TradingReferenceDate TradingReferenceDate;
            HighLimitPrice HighLimitPrice;
            LowLimitPrice LowLimitPrice;
            MaxPriceVariation MaxPriceVariation;
            FinancialInstrumentFullName FinancialInstrumentFullName;
            PartyRoleClearingOrg PartyRoleClearingOrg;
            StartDate StartDate;
            EndDate EndDate;
            TerminationType TerminationType;
            RepoSubType RepoSubType;
            MoneyOrPar MoneyOrPar;
            MaxNoOfSubstitutions MaxNoOfSubstitutions;
            PriceQuoteMethod PriceQuoteMethod;
            UserDefinedInstrument UserDefinedInstrument;
            RiskSet RiskSet;
            MarketSet MarketSet;
            InstrumentGuid InstrumentGuid;
            TermCode TermCode;
            BrokenDateTermType BrokenDateTermType;
        };
    };
}