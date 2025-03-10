using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  M D Incremental Refresh Eris Reference Data And Daily Statistics Group: Number of entries in Market Data message.
/// </summary>

public partial class MDIncrementalRefreshErisReferenceDataAndDailyStatisticsGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MdUpdateActionChar MdUpdateActionChar;
        public MdEntryType MdEntryType;
        public RptSeq RptSeq;
        public MdEntryPxDecimalOptional MdEntryPxDecimalOptional;
        public OpenCloseSettlFlag OpenCloseSettlFlag;
        public SettlPriceType SettlPriceType;
        public CalFutPxOptional CalFutPxOptional;
        public ReferenceId50 ReferenceId50;
        public MdEntrySizeOptional MdEntrySizeOptional;
        public Symbol Symbol;
        public SecurityGroup26 SecurityGroup26;
        public ProductOptional ProductOptional;
        public SecurityType SecurityType;
        public SecurityExchange SecurityExchange;
        public MaturityDate MaturityDate;
        public CouponRateOptional CouponRateOptional;
        public TradeDate TradeDate;
        public FairCouponPct FairCouponPct;
        public LegPurchaseRate LegPurchaseRate;
        public FixedNpv FixedNpv;
        public FloatNpv FloatNpv;
        public Npv Npv;
        public AccruedCoupons AccruedCoupons;
        public DailyIncrementalErisPai DailyIncrementalErisPai;
        public ErisPai ErisPai;
        public FedFundsRate FedFundsRate;
        public MinPriceIncrementOptional MinPriceIncrementOptional;
        public FixedPayment FixedPayment;
        public FloatingPayment FloatingPayment;
        public NextFixedPaymentDate NextFixedPaymentDate;
        public NextFixedPaymentAmount NextFixedPaymentAmount;
        public NextFloatingPaymentAmount NextFloatingPaymentAmount;
        public TradingReferenceDate TradingReferenceDate;
        public PreviousErisPai PreviousErisPai;
        public FedFundsDate FedFundsDate;
        public AccrualDays AccrualDays;
        public Nominal Nominal;
        public LegCreditRating LegCreditRating;
        public LegContractMultiplier LegContractMultiplier;
        public NextFloatingPaymentDate NextFloatingPaymentDate;
        public PV01 PV01;
        public DV01 DV01;
        public SettlementNpv SettlementNpv;
        public FinalSettlementFuturesPrice FinalSettlementFuturesPrice;
        public SecurityDescription SecurityDescription;
    };
};
