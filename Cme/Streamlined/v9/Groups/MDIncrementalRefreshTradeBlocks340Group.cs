using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Trade Blocks 340 Group: Number of entries in Market Data message.
    /// </summary>

    public partial class MDIncrementalRefreshTradeBlocks340Group
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdUpdateAction MdUpdateAction;
            SecurityId SecurityId;
            RptSeq RptSeq;
            MdEntryPxOptional MdEntryPxOptional;
            MdEntrySizeOptional MdEntrySizeOptional;
            NumberOfOrders NumberOfOrders;
            TradeId TradeId;
            AggressorSide AggressorSide;
            Symbol Symbol;
            SecurityGroup12 SecurityGroup12;
            SecurityType SecurityType;
            SecuritySubType SecuritySubType;
            MaturityMonthYear MaturityMonthYear;
            SecurityExchange4 SecurityExchange4;
            MaturityDate MaturityDate;
            UnitOfMeasure UnitOfMeasure;
            UnitOfMeasureCurrency3 UnitOfMeasureCurrency3;
            UnitOfMeasureQtyOptional UnitOfMeasureQtyOptional;
            CouponRate CouponRate;
            PriceType PriceType;
            TrdType TrdType;
            MdEntryId MdEntryId;
            PutOrCall PutOrCall;
            StrikePrice StrikePrice;
            RestructuringType RestructuringType;
            Seniority Seniority;
            ReferenceId100 ReferenceId100;
            StrategyLinkId StrategyLinkId;
            LegRefId LegRefId;
        };
    };
}