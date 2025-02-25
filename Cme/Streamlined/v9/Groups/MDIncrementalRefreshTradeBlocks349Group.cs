using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Trade Blocks 349 Group: Number of entries in Market Data message.
    /// </summary>

    public partial class MDIncrementalRefreshTradeBlocks349Group
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdUpdateAction MdUpdateAction;
            public SecurityId SecurityId;
            public RptSeq RptSeq;
            public MdEntryPxOptional MdEntryPxOptional;
            public MdEntrySize MdEntrySize;
            public NumberOfOrders NumberOfOrders;
            public TradeId TradeId;
            public AggressorSide AggressorSide;
            public Symbol Symbol;
            public SecurityGroup12 SecurityGroup12;
            public SecurityType SecurityType;
            public SecuritySubType SecuritySubType;
            public MaturityMonthYear MaturityMonthYear;
            public SecurityExchange4 SecurityExchange4;
            public MaturityDate MaturityDate;
            public UnitOfMeasure UnitOfMeasure;
            public UnitOfMeasureCurrency3 UnitOfMeasureCurrency3;
            public UnitOfMeasureQtyOptional UnitOfMeasureQtyOptional;
            public CouponRate CouponRate;
            public PriceType PriceType;
            public TrdType TrdType;
            public MdEntryId MdEntryId;
            public PutOrCall PutOrCall;
            public StrikePrice StrikePrice;
            public RestructuringType RestructuringType;
            public Seniority Seniority;
            public ReferenceId100 ReferenceId100;
            public StrategyLinkId StrategyLinkId;
            public LegRefId LegRefId;
        };
    };
}