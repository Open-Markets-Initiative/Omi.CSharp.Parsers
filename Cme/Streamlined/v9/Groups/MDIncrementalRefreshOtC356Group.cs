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
            MdEntryType MdEntryType;
            RptSeq RptSeq;
            MdEntryPxOptional MdEntryPxOptional;
            MdEntrySize MdEntrySize;
            Symbol Symbol;
            SecurityGroup12 SecurityGroup12;
            SecurityType SecurityType;
            MaturityMonthYear MaturityMonthYear;
            SecurityExchange SecurityExchange;
            ProductOptional ProductOptional;
            MaturityDate MaturityDate;
            CouponRate CouponRate;
            RestructuringType RestructuringType;
            Seniority Seniority;
            NotionalPercentageOutstanding NotionalPercentageOutstanding;
            PutOrCall PutOrCall;
            StrikePriceDecimal StrikePriceDecimal;
            UnitOfMeasure UnitOfMeasure;
            UnitOfMeasureCurrency UnitOfMeasureCurrency;
            UnitOfMeasureQtyDecimal UnitOfMeasureQtyDecimal;
            MdEntryDate MdEntryDate;
            OpenCloseSettlFlag OpenCloseSettlFlag;
            PriceType PriceType;
            SettlDate SettlDate;
            QuoteCondition QuoteCondition;
            MarketSector MarketSector;
            SectorGroup SectorGroup;
            SectorSubGroup SectorSubGroup;
            ProductComplex ProductComplex;
            SecuritySubType SecuritySubType;
            VolType VolType;
            ReferenceId100 ReferenceId100;
        };
    };
}