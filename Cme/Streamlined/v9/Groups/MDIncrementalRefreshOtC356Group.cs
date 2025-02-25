using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Ot C 356 Group: Number of entries in Market Data message.
    /// </summary>

    public partial class MDIncrementalRefreshOtC356Group
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdEntryType MdEntryType;
            public RptSeq RptSeq;
            public MdEntryPxOptional MdEntryPxOptional;
            public MdEntrySize MdEntrySize;
            public Symbol Symbol;
            public SecurityGroup12 SecurityGroup12;
            public SecurityType SecurityType;
            public MaturityMonthYear MaturityMonthYear;
            public SecurityExchange SecurityExchange;
            public ProductOptional ProductOptional;
            public MaturityDate MaturityDate;
            public CouponRate CouponRate;
            public RestructuringType RestructuringType;
            public Seniority Seniority;
            public NotionalPercentageOutstanding NotionalPercentageOutstanding;
            public PutOrCall PutOrCall;
            public StrikePriceDecimal StrikePriceDecimal;
            public UnitOfMeasure UnitOfMeasure;
            public UnitOfMeasureCurrency UnitOfMeasureCurrency;
            public UnitOfMeasureQtyDecimal UnitOfMeasureQtyDecimal;
            public MdEntryDate MdEntryDate;
            public OpenCloseSettlFlag OpenCloseSettlFlag;
            public PriceType PriceType;
            public SettlDate SettlDate;
            public QuoteCondition QuoteCondition;
            public MarketSector MarketSector;
            public SectorGroup SectorGroup;
            public SectorSubGroup SectorSubGroup;
            public ProductComplex ProductComplex;
            public SecuritySubType SecuritySubType;
            public VolType VolType;
            public ReferenceId100 ReferenceId100;
        };
    };
}