using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Instrument Definition Future: MDInstrumentDefinitionFuture
    /// </summary>

    public partial class MdInstrumentDefinitionFuture
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
            MaturityMonthYear MaturityMonthYear;
            Currency Currency;
            SettlCurrency SettlCurrency;
            MatchAlgorithm MatchAlgorithm;
            MinTradeVol MinTradeVol;
            MaxTradeVol MaxTradeVol;
            MinPriceIncrement MinPriceIncrement;
            DisplayFactor DisplayFactor;
            MainFraction MainFraction;
            SubFraction SubFraction;
            PriceDisplayFormat PriceDisplayFormat;
            UnitOfMeasure UnitOfMeasure;
            UnitOfMeasureQty UnitOfMeasureQty;
            TradingReferencePrice TradingReferencePrice;
            SettlPriceType SettlPriceType;
            OpenInterestQty OpenInterestQty;
            ClearedVolume ClearedVolume;
            HighLimitPrice HighLimitPrice;
            LowLimitPrice LowLimitPrice;
            MaxPriceVariation MaxPriceVariation;
            DecayQuantity DecayQuantity;
            DecayStartDate DecayStartDate;
            OriginalContractSize OriginalContractSize;
            ContractMultiplier ContractMultiplier;
            ContractMultiplierUnit ContractMultiplierUnit;
            FlowScheduleType FlowScheduleType;
            MinPriceIncrementAmount MinPriceIncrementAmount;
            UserDefinedInstrument UserDefinedInstrument;
            TradingReferenceDate TradingReferenceDate;
            InstrumentGuid InstrumentGuid;
        };
    };
}