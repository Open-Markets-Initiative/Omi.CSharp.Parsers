using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Trade Blocks 365 Group: Number of entries in Market Data message.
    /// </summary>

    public partial class MDIncrementalRefreshTradeBlocks365Group
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdUpdateAction MdUpdateAction;
            SecurityId SecurityId;
            RptSeq RptSeq;
            MdEntryPx9 MdEntryPx9;
            MdEntrySize MdEntrySize;
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
            UnitOfMeasureQtyDecimalOptional UnitOfMeasureQtyDecimalOptional;
            CouponRate CouponRate;
            PriceType PriceType;
            TrdType TrdType;
            MdEntryId MdEntryId;
            PutOrCall PutOrCall;
            StrikePriceDecimalOptional StrikePriceDecimalOptional;
            RestructuringType RestructuringType;
            Seniority Seniority;
            ReferenceId100 ReferenceId100;
            StrategyLinkId StrategyLinkId;
            LegRefId LegRefId;
        };
    };
}