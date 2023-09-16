using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Eris Reference Data And Daily Statistics Group: Number of entries in Market Data message.
    /// </summary>

    public partial class MDIncrementalRefreshErisReferenceDataAndDailyStatisticsGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdUpdateActionChar MdUpdateActionChar;
            MdEntryType MdEntryType;
            RptSeq RptSeq;
            MdEntryPxDecimalOptional MdEntryPxDecimalOptional;
            OpenCloseSettlFlag OpenCloseSettlFlag;
            SettlPriceType SettlPriceType;
            CalFutPxOptional CalFutPxOptional;
            ReferenceId50 ReferenceId50;
            MdEntrySizeOptional MdEntrySizeOptional;
            Symbol Symbol;
            SecurityGroup26 SecurityGroup26;
            ProductOptional ProductOptional;
            SecurityType SecurityType;
            SecurityExchange SecurityExchange;
            MaturityDate MaturityDate;
            CouponRateOptional CouponRateOptional;
            TradeDate TradeDate;
            FairCouponPct FairCouponPct;
            LegPurchaseRate LegPurchaseRate;
            FixedNpv FixedNpv;
            FloatNpv FloatNpv;
            Npv Npv;
            AccruedCoupons AccruedCoupons;
            DailyIncrementalErisPai DailyIncrementalErisPai;
            ErisPai ErisPai;
            FedFundsRate FedFundsRate;
            MinPriceIncrementOptional MinPriceIncrementOptional;
            FixedPayment FixedPayment;
            FloatingPayment FloatingPayment;
            NextFixedPaymentDate NextFixedPaymentDate;
            NextFixedPaymentAmount NextFixedPaymentAmount;
            NextFloatingPaymentAmount NextFloatingPaymentAmount;
            TradingReferenceDate TradingReferenceDate;
            PreviousErisPai PreviousErisPai;
            FedFundsDate FedFundsDate;
            AccrualDays AccrualDays;
            Nominal Nominal;
            LegCreditRating LegCreditRating;
            LegContractMultiplier LegContractMultiplier;
            NextFloatingPaymentDate NextFloatingPaymentDate;
            PV01 PV01;
            DV01 DV01;
            SettlementNpv SettlementNpv;
            FinalSettlementFuturesPrice FinalSettlementFuturesPrice;
            SecurityDescription SecurityDescription;
        };
    };
}