using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Instrument Definition Fixed Income: MDInstrumentDefinitionFixedIncome
    /// </summary>

    public partial class MdInstrumentDefinitionFixedIncome
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
            MinPriceIncrementOptional MinPriceIncrementOptional;
            DisplayFactor DisplayFactor;
            MainFraction MainFraction;
            SubFraction SubFraction;
            PriceDisplayFormat PriceDisplayFormat;
            UnitOfMeasure UnitOfMeasure;
            UnitOfMeasureQty UnitOfMeasureQty;
            TradingReferencePrice TradingReferencePrice;
            TradingReferenceDate TradingReferenceDate;
            HighLimitPrice HighLimitPrice;
            LowLimitPrice LowLimitPrice;
            MaxPriceVariation MaxPriceVariation;
            MinPriceIncrementAmount MinPriceIncrementAmount;
            IssueDate IssueDate;
            DatedDate DatedDate;
            MaturityDate MaturityDate;
            CouponRate CouponRate;
            ParValue ParValue;
            CouponFrequencyUnit CouponFrequencyUnit;
            CouponFrequencyPeriod CouponFrequencyPeriod;
            CouponDayCount CouponDayCount;
            CountryOfIssue CountryOfIssue;
            Issuer Issuer;
            FinancialInstrumentFullName FinancialInstrumentFullName;
            SecurityAltId SecurityAltId;
            SecurityAltIdSource SecurityAltIdSource;
            PriceQuoteMethod PriceQuoteMethod;
            PartyRoleClearingOrg PartyRoleClearingOrg;
            UserDefinedInstrument UserDefinedInstrument;
            RiskSet RiskSet;
            MarketSet MarketSet;
            InstrumentGuid InstrumentGuid;
        };
    };
}