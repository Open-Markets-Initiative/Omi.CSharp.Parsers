namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Reason Code: These reason codes are provided by the matching engine and qualify the event that produced the message. See Appendix for list of values.
    /// </summary>
    public enum ReasonCode : ushort
    {
        /// <summary>
        ///  OK
        /// </summary>
        Ok = 0;

        /// <summary>
        ///  Invalid StopPx
        /// </summary>
        InvalidStopPx = 27;

        /// <summary>
        ///  Invalid SenderCompID
        /// </summary>
        InvalidSenderCompId = 1;

        /// <summary>
        ///  Invalid Client ID
        /// </summary>
        InvalidClientId = 28;

        /// <summary>
        ///  Invalid SenderSubID
        /// </summary>
        InvalidSenderSubId = 2;

        /// <summary>
        ///  Invalid MinQty
        /// </summary>
        InvalidMinQty = 29;

        /// <summary>
        ///  Invalid SendingTime
        /// </summary>
        InvalidSendingTime = 3;

        /// <summary>
        ///  Invalid MaxFloor
        /// </summary>
        InvalidMaxFloor = 30;

        /// <summary>
        ///  Invalid TargetCompID
        /// </summary>
        InvalidTargetCompId = 4;

        /// <summary>
        ///  Invalid LocateReqd
        /// </summary>
        InvalidLocateReqd = 31;

        /// <summary>
        ///  Invalid TargetSubId
        /// </summary>
        InvalidTargetSubId = 5;

        /// <summary>
        ///  Invalid ExpireTime
        /// </summary>
        InvalidExpireTime = 32;

        /// <summary>
        ///  Invalid OnBehalfOfCompID
        /// </summary>
        InvalidOnBehalfOfCompId = 6;

        /// <summary>
        ///  Invalid SecurityType
        /// </summary>
        InvalidSecurityType = 33;

        /// <summary>
        ///  Invalid OnBehalfOfSubID
        /// </summary>
        InvalidOnBehalfOfSubId = 7;

        /// <summary>
        ///  Invalid MaturityMonthYear
        /// </summary>
        InvalidMaturityMonthYear = 34;

        /// <summary>
        ///  Invalid DeliverToCompID
        /// </summary>
        InvalidDeliverToCompId = 8;

        /// <summary>
        ///  Invalid PutOrCall
        /// </summary>
        InvalidPutOrCall = 35;

        /// <summary>
        ///  Invalid DeliverToSubID
        /// </summary>
        InvalidDeliverToSubId = 9;

        /// <summary>
        ///  Invalid StrikePrice
        /// </summary>
        InvalidStrikePrice = 36;

        /// <summary>
        ///  Invalid Account
        /// </summary>
        InvalidAccount = 10;

        /// <summary>
        ///  Invalid CoveredOrUncovered
        /// </summary>
        InvalidCoveredOrUncovered = 37;

        /// <summary>
        ///  Invalid ClOrdID
        /// </summary>
        InvalidClOrdId = 11;

        /// <summary>
        ///  Invalid CustomerOrFirm
        /// </summary>
        InvalidCustomerOrFirm = 38;

        /// <summary>
        ///  Invalid ExecInst
        /// </summary>
        InvalidExecInst = 12;

        /// <summary>
        ///  Invalid MaturityDay
        /// </summary>
        InvalidMaturityDay = 39;

        /// <summary>
        ///  Invalid IDSource
        /// </summary>
        InvalidIdSource = 13;

        /// <summary>
        ///  Invalid PegDifference
        /// </summary>
        InvalidPegDifference = 40;

        /// <summary>
        ///  Invalid OrderQty
        /// </summary>
        InvalidOrderQty = 14;

        /// <summary>
        ///  Invalid SellersDays
        /// </summary>
        InvalidSellersDays = 41;

        /// <summary>
        ///  Invalid OrdType
        /// </summary>
        InvalidOrdType = 15;

        /// <summary>
        ///  Invalid TradingSessionID
        /// </summary>
        InvalidTradingSessionId = 42;

        /// <summary>
        ///  Invalid Price
        /// </summary>
        InvalidPrice = 16;

        /// <summary>
        ///  Invalid NoTradingSessions
        /// </summary>
        InvalidNoTradingSessions = 43;

        /// <summary>
        ///  Invalid Order Capacity
        /// </summary>
        InvalidOrderCapacity = 17;

        /// <summary>
        ///  Invalid DiscretionInst
        /// </summary>
        InvalidDiscretionInst = 44;

        /// <summary>
        ///  Invalid Security ID
        /// </summary>
        InvalidSecurityId = 18;

        /// <summary>
        ///  Invalid DiscretionOffset
        /// </summary>
        InvalidDiscretionOffset = 45;

        /// <summary>
        ///  Invalid Side
        /// </summary>
        InvalidSide = 19;

        /// <summary>
        ///  Invalid PriceType
        /// </summary>
        InvalidPriceType = 46;

        /// <summary>
        ///  Invalid Symbol/Series
        /// </summary>
        InvalidSymbolSeries = 20;

        /// <summary>
        ///  Invalid ClearingFirm
        /// </summary>
        InvalidClearingFirm = 47;

        /// <summary>
        ///  Invalid Text
        /// </summary>
        InvalidText = 21;

        /// <summary>
        ///  Invalid ClearingAccount
        /// </summary>
        InvalidClearingAccount = 48;

        /// <summary>
        ///  Invalid TimeInForce
        /// </summary>
        InvalidTimeInForce = 22;

        /// <summary>
        ///  Invalid PartyID
        /// </summary>
        InvalidPartyId = 49;

        /// <summary>
        ///  Invalid Settlement Type
        /// </summary>
        InvalidSettlementType = 23;

        /// <summary>
        ///  Invalid Optional Data
        /// </summary>
        InvalidOptionalData = 50;

        /// <summary>
        ///  Invalid FutSettDate
        /// </summary>
        InvalidFutSettDate = 24;

        /// <summary>
        ///  Invalid CrossID
        /// </summary>
        InvalidCrossId = 51;

        /// <summary>
        ///  Invalid SymbolSfx
        /// </summary>
        InvalidSymbolSfx = 25;

        /// <summary>
        ///  Invalid StrategyIndicator
        /// </summary>
        InvalidStrategyIndicator = 52;

        /// <summary>
        ///  Invalid Open/Close
        /// </summary>
        InvalidOpenClose = 26;

        /// <summary>
        ///  Invalid TradeID
        /// </summary>
        InvalidTradeId = 53;

        /// <summary>
        ///  Invalid NoSelfTrade
        /// </summary>
        InvalidNoSelfTrade = 54;

        /// <summary>
        ///  Invalid StockLegGiveUp
        /// </summary>
        InvalidStockLegGiveUp = 87;

        /// <summary>
        ///  Invalid CAPStrategy
        /// </summary>
        InvalidCapStrategy = 55;

        /// <summary>
        ///  Invalid NoLegs
        /// </summary>
        InvalidNoLegs = 88;

        /// <summary>
        ///  Invalid SpecialOrdType
        /// </summary>
        InvalidSpecialOrdType = 56;

        /// <summary>
        ///  Invalid LegPositionEffect
        /// </summary>
        InvalidLegPositionEffect = 89;

        /// <summary>
        ///  Invalid RoutingInst
        /// </summary>
        InvalidRoutingInst = 57;

        /// <summary>
        ///  Invalid LegSymbol
        /// </summary>
        InvalidLegSymbol = 90;

        /// <summary>
        ///  Invalid OffsetPrice
        /// </summary>
        InvalidOffsetPrice = 58;

        /// <summary>
        ///  Invalid LegCFICode
        /// </summary>
        InvalidLegCfiCode = 91;

        /// <summary>
        ///  Invalid ExtendedExecInst
        /// </summary>
        InvalidExtendedExecInst = 59;

        /// <summary>
        ///  Invalid LegMaturityDate
        /// </summary>
        InvalidLegMaturityDate = 92;

        /// <summary>
        ///  Invalid IntroducingBadgeID
        /// </summary>
        InvalidIntroducingBadgeId = 60;

        /// <summary>
        ///  Invalid LegStrikePrice
        /// </summary>
        InvalidLegStrikePrice = 93;

        /// <summary>
        ///  Invalid BillTo
        /// </summary>
        InvalidBillTo = 61;

        /// <summary>
        ///  Invalid LegContractMultiplier
        /// </summary>
        InvalidLegContractMultiplier = 94;

        /// <summary>
        ///  Invalid ParentFirmClOrdID
        /// </summary>
        InvalidParentFirmClOrdId = 62;

        /// <summary>
        ///  Invalid LegRatioQty
        /// </summary>
        InvalidLegRatioQty = 95;

        /// <summary>
        ///  Invalid ParentFirmExchangeOrdID
        /// </summary>
        InvalidParentFirmExchangeOrdId = 63;

        /// <summary>
        ///  Invalid LegSide
        /// </summary>
        InvalidLegSide = 96;

        /// <summary>
        ///  Invalid ParentFirm
        /// </summary>
        InvalidParentFirm = 64;

        /// <summary>
        ///  Invalid LegRefID
        /// </summary>
        InvalidLegRefId = 97;

        /// <summary>
        ///  Invalid InterestType
        /// </summary>
        InvalidInterestType = 65;

        /// <summary>
        ///  Unsupported Order Type
        /// </summary>
        UnsupportedOrderType = 98;

        /// <summary>
        ///  Invalid DisplayInd
        /// </summary>
        InvalidDisplayInd = 66;

        /// <summary>
        ///  UROUT
        /// </summary>
        Urout = 99;

        /// <summary>
        ///  Invalid PegInd
        /// </summary>
        InvalidPegInd = 67;

        /// <summary>
        ///  Primary Market Not Available
        /// </summary>
        PrimaryMarketNotAvailable = 100;

        /// <summary>
        ///  Invalid CeilingFloorPrice
        /// </summary>
        InvalidCeilingFloorPrice = 68;

        /// <summary>
        ///  No NBBO/PBBO for Peg
        /// </summary>
        NoNbbopbboForPeg = 101;

        /// <summary>
        ///  Invalid MinPegQty
        /// </summary>
        InvalidMinPegQty = 69;

        /// <summary>
        ///  No Market for Market Order
        /// </summary>
        NoMarketForMarketOrder = 102;

        /// <summary>
        ///  Invalid DOrderAuctionPrice
        /// </summary>
        InvalidDOrderAuctionPrice = 70;

        /// <summary>
        ///  Marketable Price
        /// </summary>
        MarketablePrice = 103;

        /// <summary>
        ///  Invalid DiscMaxVol
        /// </summary>
        InvalidDiscMaxVol = 71;

        /// <summary>
        ///  Done for Day
        /// </summary>
        DoneForDay = 104;

        /// <summary>
        ///  Invalid DicsRouteInd
        /// </summary>
        InvalidDicsRouteInd = 72;

        /// <summary>
        ///  Credit Limit Violation
        /// </summary>
        CreditLimitViolation = 105;

        /// <summary>
        ///  Invalid MinimumTriggerVol (MTV)
        /// </summary>
        InvalidMinimumTriggerVolMtv = 73;

        /// <summary>
        ///  Cancel Remaining IOC
        /// </summary>
        CancelRemainingIoc = 106;

        /// <summary>
        ///  Invalid Attributed Quote
        /// </summary>
        InvalidAttributedQuote = 74;

        /// <summary>
        ///  Too Late to Cancel
        /// </summary>
        TooLateToCancel = 107;

        /// <summary>
        ///  Invalid Proactive If Locked
        /// </summary>
        InvalidProactiveIfLocked = 75;

        /// <summary>
        ///  InvalidPossResend
        /// </summary>
        InvalidPossResend = 108;

        /// <summary>
        ///  System not available
        /// </summary>
        SystemNotAvailable = 76;

        /// <summary>
        ///  Cancel Pending
        /// </summary>
        CancelPending = 109;

        /// <summary>
        ///  System full (MENG_RATE_EXCEEDED)
        /// </summary>
        SystemFullMengrateexceeded = 77;

        /// <summary>
        ///  Symbol/Series already opened
        /// </summary>
        SymbolSeriesAlreadyOpened = 110;

        /// <summary>
        ///  Throttle Reject
        /// </summary>
        ThrottleReject = 78;

        /// <summary>
        ///  Firm Bulk Cancel
        /// </summary>
        FirmBulkCancel = 111;

        /// <summary>
        ///  Symbol/Series Halted
        /// </summary>
        SymbolSeriesHalted = 79;

        /// <summary>
        ///  OnBehalfOfCompID Blocked
        /// </summary>
        OnBehalfOfCompIdBlocked = 112;

        /// <summary>
        ///  No symbol/series permission
        /// </summary>
        NoSymbolseriesPermission = 80;

        /// <summary>
        ///  ClearingFirm Blocked
        /// </summary>
        ClearingFirmBlocked = 113;

        /// <summary>
        ///  Price Too Far Outside
        /// </summary>
        PriceTooFarOutside = 81;

        /// <summary>
        ///  Cancel/Replace Pending
        /// </summary>
        CancelReplacePending = 114;

        /// <summary>
        ///  MWCB Halt
        /// </summary>
        MwcbHalt = 82;

        /// <summary>
        ///  Modify Pending
        /// </summary>
        ModifyPending = 115;

        /// <summary>
        ///  Market Closed
        /// </summary>
        MarketClosed = 83;

        /// <summary>
        ///  Cannot Flip Imbalance
        /// </summary>
        CannotFlipImbalance = 116;

        /// <summary>
        ///  Symbol/Series Closed
        /// </summary>
        SymbolSeriesClosed = 84;

        /// <summary>
        ///  Cannot Increase Imbalance
        /// </summary>
        CannotIncreaseImbalance = 117;

        /// <summary>
        ///  LULD Cancel Instruction
        /// </summary>
        LuldCancelInstruction = 85;

        /// <summary>
        ///  Pending Cancel - Imbalance Freeze
        /// </summary>
        PendingCancelImbalanceFreeze = 118;

        /// <summary>
        ///  No Price Slide Inst During SSR
        /// </summary>
        NoPriceSlideInstDuringSsr = 86;

        /// <summary>
        ///  Pending Replace - Imbalance Freeze
        /// </summary>
        PendingReplaceImbalanceFreeze = 119;

        /// <summary>
        ///  Pending Modify - Imbalance Freeze
        /// </summary>
        PendingModifyImbalanceFreeze = 120;

        /// <summary>
        ///  SSH Price below NBB on ISO
        /// </summary>
        SshPriceBelowNbbOnIso = 152;

        /// <summary>
        ///  Pending Cancel - Routed Interest
        /// </summary>
        PendingCancelRoutedInterest = 121;

        /// <summary>
        ///  IOC Received while Auction Running
        /// </summary>
        IocReceivedWhileAuctionRunning = 153;

        /// <summary>
        ///  Pending Replace - Routed Interest
        /// </summary>
        PendingReplaceRoutedInterest = 122;

        /// <summary>
        ///  Pending - Session Transition
        /// </summary>
        PendingSessionTransition = 154;

        /// <summary>
        ///  Pending Modify - Routed Interest
        /// </summary>
        PendingModifyRoutedInterest = 123;

        /// <summary>
        ///  Pend Cancel - Session Transition
        /// </summary>
        PendCancelSessionTransition = 155;

        /// <summary>
        ///  Pending - Auction Running
        /// </summary>
        PendingAuctionRunning = 124;

        /// <summary>
        ///  Pend Modify - Session Transition
        /// </summary>
        PendModifySessionTransition = 156;

        /// <summary>
        ///  Duplicative Order Check
        /// </summary>
        DuplicativeOrderCheck = 125;

        /// <summary>
        ///  Pend Replace - Session Transition
        /// </summary>
        PendReplaceSessionTransition = 157;

        /// <summary>
        ///  Cancelled by Exchange
        /// </summary>
        CancelledByExchange = 126;

        /// <summary>
        ///  Invalid For Tick Pilot
        /// </summary>
        InvalidForTickPilot = 158;

        /// <summary>
        ///  New Order
        /// </summary>
        NewOrder = 127;

        /// <summary>
        ///  Invalid MMID
        /// </summary>
        InvalidMmid = 159;

        /// <summary>
        ///  Fill
        /// </summary>
        Fill = 128;

        /// <summary>
        ///  Invalid MPID
        /// </summary>
        InvalidMpid = 160;

        /// <summary>
        ///  Partial Fill
        /// </summary>
        PartialFill = 129;

        /// <summary>
        ///  Invalid CancelInsteadOfReprice
        /// </summary>
        InvalidCancelInsteadOfReprice = 161;

        /// <summary>
        ///  Reduced
        /// </summary>
        Reduced = 130;

        /// <summary>
        ///  Invalid RetailIndicator
        /// </summary>
        InvalidRetailIndicator = 162;

        /// <summary>
        ///  Replaced
        /// </summary>
        Replaced = 131;

        /// <summary>
        ///  SenderCompID Not Active
        /// </summary>
        SenderCompIdNotActive = 163;

        /// <summary>
        ///  No Market for Cross
        /// </summary>
        NoMarketForCross = 132;

        /// <summary>
        ///  MPID Blocked
        /// </summary>
        MpidBlocked = 164;

        /// <summary>
        ///  STP Cancel
        /// </summary>
        StpCancel = 133;

        /// <summary>
        ///  Invalid Timestamp
        /// </summary>
        InvalidTimestamp = 165;

        /// <summary>
        ///  Invalid PossDupe
        /// </summary>
        InvalidPossDupe = 134;

        /// <summary>
        ///  Invalid Permission for SenderCompID
        /// </summary>
        InvalidPermissionForSenderCompId = 166;

        /// <summary>
        ///  TPID Blocked
        /// </summary>
        TpidBlocked = 135;

        /// <summary>
        ///  Invalid UserData
        /// </summary>
        InvalidUserData = 167;

        /// <summary>
        ///  Invalid Bulk Cancel
        /// </summary>
        InvalidBulkCancel = 136;

        /// <summary>
        ///  Pillar Risk Mitigation
        /// </summary>
        PillarRiskMitigation = 168;

        /// <summary>
        ///  Pending Bulk Cancel
        /// </summary>
        PendingBulkCancel = 137;

        /// <summary>
        ///  No Last Sale for Peg
        /// </summary>
        NoLastSaleForPeg = 169;

        /// <summary>
        ///  Symbol/Series Not Open
        /// </summary>
        SymbolSeriesNotOpen = 138;

        /// <summary>
        ///  Symbol Pending Closing Auction
        /// </summary>
        SymbolPendingClosingAuction = 170;

        /// <summary>
        ///  Symbol/Series Suspended
        /// </summary>
        SymbolSeriesSuspended = 139;

        /// <summary>
        ///  Extreme Closing Order Imbalance
        /// </summary>
        ExtremeClosingOrderImbalance = 171;

        /// <summary>
        ///  Symbol IPO Halt
        /// </summary>
        SymbolIpoHalt = 140;

        /// <summary>
        ///  Invalid Multi-Message
        /// </summary>
        InvalidMultiMessage = 172;

        /// <summary>
        ///  Invld Inst During Imbalance Freeze
        /// </summary>
        InvldInstDuringImbalanceFreeze = 141;

        /// <summary>
        ///  Invalid Request Targeting Manual SenderCompID
        /// </summary>
        InvalidRequestTargetingManualSenderCompId = 173;

        /// <summary>
        ///  Invld Inst After Cutoff Time
        /// </summary>
        InvldInstAfterCutoffTime = 142;

        /// <summary>
        ///  Invalid DMMRejectReason
        /// </summary>
        InvalidDmmRejectReason = 174;

        /// <summary>
        ///  Cancelled by Primary Market
        /// </summary>
        CancelledByPrimaryMarket = 143;

        /// <summary>
        ///  Pending - Pending Auction State
        /// </summary>
        PendingPendingAuctionState = 175;

        /// <summary>
        ///  Pending - Imbalance Freeze
        /// </summary>
        PendingImbalanceFreeze = 144;

        /// <summary>
        ///  Pending Cancel – Pending Auction State
        /// </summary>
        PendingCancelPendingAuctionState = 176;

        /// <summary>
        ///  No RLP Permission
        /// </summary>
        NoRlpPermission = 145;

        /// <summary>
        ///  Pending Modify – Pending Auction State
        /// </summary>
        PendingModifyPendingAuctionState = 177;

        /// <summary>
        ///  Invalid Instruction for IOC's
        /// </summary>
        InvalidInstructionForIoCs = 146;

        /// <summary>
        ///  Pending Replace – Pending Auction State
        /// </summary>
        PendingReplacePendingAuctionState = 178;

        /// <summary>
        ///  System full (CG_RATE_EXCEEDED)
        /// </summary>
        SystemFullCgrateexceeded = 147;

        /// <summary>
        ///  Cancelled - DMM Manual Order Re-price
        /// </summary>
        CancelledDmmManualOrderReprice = 179;

        /// <summary>
        ///  Pending Cancel - Auction Running
        /// </summary>
        PendingCancelAuctionRunning = 148;

        /// <summary>
        ///  Too early to open
        /// </summary>
        TooEarlyToOpen = 180;

        /// <summary>
        ///  Pending Modify - Auction Running
        /// </summary>
        PendingModifyAuctionRunning = 149;

        /// <summary>
        ///  Too early to close
        /// </summary>
        TooEarlyToClose = 181;

        /// <summary>
        ///  Pending Replace - Auction Running
        /// </summary>
        PendingReplaceAuctionRunning = 150;

        /// <summary>
        ///  Symbol not frozen by Auction Request
        /// </summary>
        SymbolNotFrozenByAuctionRequest = 182;

        /// <summary>
        ///  Invld Inst for Pending Order
        /// </summary>
        InvldInstForPendingOrder = 151;

        /// <summary>
        ///  Symbol is frozen by DBK GUI
        /// </summary>
        SymbolIsFrozenByDbkGui = 183;

        /// <summary>
        ///  Too Late - Auction Running
        /// </summary>
        TooLateAuctionRunning = 184;

        /// <summary>
        ///  DMM GUI Reduction in Manual Order Qty
        /// </summary>
        DmmGuiReductionInManualOrderQty = 218;

        /// <summary>
        ///  Too Late - Symbol Transition
        /// </summary>
        TooLateSymbolTransition = 185;

        /// <summary>
        ///  Cross Eligible
        /// </summary>
        CrossEligible = 219;

        /// <summary>
        ///  No Eligible Crossing Interest
        /// </summary>
        NoEligibleCrossingInterest = 186;

        /// <summary>
        ///  Dry Run
        /// </summary>
        DryRun = 220;

        /// <summary>
        ///  Book is locked/crossed
        /// </summary>
        BookIsLockedcrossed = 187;

        /// <summary>
        ///  Unsupported by BrokerPlex
        /// </summary>
        UnsupportedByBrokerPlex = 221;

        /// <summary>
        ///  No interest exists
        /// </summary>
        NoInterestExists = 188;

        /// <summary>
        ///  Cross Blocked by BBO/PBBO
        /// </summary>
        CrossBlockedByBbopbbo = 222;

        /// <summary>
        ///  Imbalance too large
        /// </summary>
        ImbalanceTooLarge = 189;

        /// <summary>
        ///  Risk - Single Ord Max Qty
        /// </summary>
        RiskSingleOrdMaxQty = 223;

        /// <summary>
        ///  SSH price below SSR filing price
        /// </summary>
        SshPriceBelowSsrFilingPrice = 190;

        /// <summary>
        ///  Risk - Single Ord Max Notional
        /// </summary>
        RiskSingleOrdMaxNotional = 224;

        /// <summary>
        ///  Symbol Already Closed
        /// </summary>
        SymbolAlreadyClosed = 191;

        /// <summary>
        ///  Risk - Gross Credit Breach
        /// </summary>
        RiskGrossCreditBreach = 225;

        /// <summary>
        ///  Opening template opened
        /// </summary>
        OpeningTemplateOpened = 192;

        /// <summary>
        ///  Risk - Kill Switch
        /// </summary>
        RiskKillSwitch = 226;

        /// <summary>
        ///  Closing template opened
        /// </summary>
        ClosingTemplateOpened = 193;

        /// <summary>
        ///  Invalid RouteToBroker
        /// </summary>
        InvalidRouteToBroker = 227;

        /// <summary>
        ///  PRIN entered on auction template
        /// </summary>
        PrinEnteredOnAuctionTemplate = 194;

        /// <summary>
        ///  Spread Too Wide
        /// </summary>
        SpreadTooWide = 228;

        /// <summary>
        ///  Mandatory Indication submitted
        /// </summary>
        MandatoryIndicationSubmitted = 195;

        /// <summary>
        ///  Expire FOK
        /// </summary>
        ExpireFok = 229;

        /// <summary>
        ///  Pending Crowd exists
        /// </summary>
        PendingCrowdExists = 196;

        /// <summary>
        ///  Locks displayed interest
        /// </summary>
        LocksDisplayedInterest = 230;

        /// <summary>
        ///  No consolidated last sale
        /// </summary>
        NoConsolidatedLastSale = 197;

        /// <summary>
        ///  MMQuote Price lock/cross contra side NBBO
        /// </summary>
        MmQuotePriceLockcrossContraSideNbbo = 231;

        /// <summary>
        ///  Paired qty exceeds max trade parameter
        /// </summary>
        PairedQtyExceedsMaxTradeParameter = 198;

        /// <summary>
        ///  Invalid Leg Symbol
        /// </summary>
        InvalidLegSymbol = 232;

        /// <summary>
        ///  LULD or MWCB timer running
        /// </summary>
        LuldOrMwcbTimerRunning = 199;

        /// <summary>
        ///  Duplicate Leg Symbol
        /// </summary>
        DuplicateLegSymbol = 233;

        /// <summary>
        ///  Locking/Crossing Away Quote
        /// </summary>
        LockingCrossingAwayQuote = 200;

        /// <summary>
        ///  Symbol Not In Underlying
        /// </summary>
        SymbolNotInUnderlying = 234;

        /// <summary>
        ///  Cross Not Eligible
        /// </summary>
        CrossNotEligible = 201;

        /// <summary>
        ///  Leg ratios not in the most reduced form
        /// </summary>
        LegRatiosNotInTheMostReducedForm = 235;

        /// <summary>
        ///  Reserved for future use
        /// </summary>
        ReservedForFutureUse = 202;

        /// <summary>
        ///  Option leg ratio too high
        /// </summary>
        OptionLegRatioTooHigh = 236;

        /// <summary>
        ///  Pending Acceptance (for Ack on order arrival)
        /// </summary>
        PendingAcceptanceForAckOnOrderArrival = 203;

        /// <summary>
        ///  Stock leg ratio too low
        /// </summary>
        StockLegRatioTooLow = 237;

        /// <summary>
        ///  Rejected Cancel by DMM
        /// </summary>
        RejectedCancelByDmm = 204;

        /// <summary>
        ///  Complex series already exists
        /// </summary>
        ComplexSeriesAlreadyExists = 238;

        /// <summary>
        ///  Cancelled by DMM
        /// </summary>
        CancelledByDmm = 205;

        /// <summary>
        ///  Number of legs incorrect
        /// </summary>
        NumberOfLegsIncorrect = 239;

        /// <summary>
        ///  Price is outside allowable range
        /// </summary>
        PriceIsOutsideAllowableRange = 206;

        /// <summary>
        ///  Cancel - does not set NBBO inst
        /// </summary>
        CancelDoesNotSetNbboInst = 240;

        /// <summary>
        ///  Auction Validation In Progress
        /// </summary>
        AuctionValidationInProgress = 207;

        /// <summary>
        ///  Cancel - avoid reprice inst
        /// </summary>
        CancelAvoidRepriceInst = 241;

        /// <summary>
        ///  Invalid ManualActionID
        /// </summary>
        InvalidManualActionId = 208;

        /// <summary>
        ///  Allow reprice once, then cancel inst
        /// </summary>
        AllowRepriceOnceThenCancelInst = 242;

        /// <summary>
        ///  Invalid AuctionSellIndicator
        /// </summary>
        InvalidAuctionSellIndicator = 209;

        /// <summary>
        ///  Invalid AllocationPct
        /// </summary>
        InvalidAllocationPct = 243;

        /// <summary>
        ///  Invalid IntradaySellShortQty
        /// </summary>
        InvalidIntradaySellShortQty = 210;

        /// <summary>
        ///  InvalidMMQuoteType
        /// </summary>
        InvalidMmQuoteType = 244;

        /// <summary>
        ///  Indication Template is Open
        /// </summary>
        IndicationTemplateIsOpen = 211;

        /// <summary>
        ///  Invalid MMSentTime
        /// </summary>
        InvalidMmSentTime = 245;

        /// <summary>
        ///  No Prev Closing Price
        /// </summary>
        NoPrevClosingPrice = 212;

        /// <summary>
        ///  Series Expired
        /// </summary>
        SeriesExpired = 246;

        /// <summary>
        ///  Cancelled due to Trading Collars
        /// </summary>
        CancelledDueToTradingCollars = 213;

        /// <summary>
        ///  Invalid GiveUpMMID
        /// </summary>
        InvalidGiveUpMmid = 247;

        /// <summary>
        ///  Underlying is in LULD State
        /// </summary>
        UnderlyingIsInLuldState = 214;

        /// <summary>
        ///  Invalid NoSides
        /// </summary>
        InvalidNoSides = 248;

        /// <summary>
        ///  Invalid ManualResponseType
        /// </summary>
        InvalidManualResponseType = 215;

        /// <summary>
        ///  Pending TO Acceptance
        /// </summary>
        PendingToAcceptance = 249;

        /// <summary>
        ///  No NYSE last sale
        /// </summary>
        NoNyseLastSale = 216;

        /// <summary>
        ///  DMM API Request Rejected
        /// </summary>
        DmmApiRequestRejected = 250;

        /// <summary>
        ///  Symbol Direct Listing State
        /// </summary>
        SymbolDirectListingState = 217;

        /// <summary>
        ///  Invalid BulkAction
        /// </summary>
        InvalidBulkAction = 251;

        /// <summary>
        ///  Invalid CancelScope
        /// </summary>
        InvalidCancelScope = 252;

        /// <summary>
        ///  Risk - Roll Transact Breach
        /// </summary>
        RiskRollTransactBreach = 284;

        /// <summary>
        ///  No Legal Width Spread
        /// </summary>
        NoLegalWidthSpread = 253;

        /// <summary>
        ///  Risk - Roll Vol Breach
        /// </summary>
        RiskRollVolBreach = 285;

        /// <summary>
        ///  Invalid TargetCancelMPID
        /// </summary>
        InvalidTargetCancelMpid = 254;

        /// <summary>
        ///  Risk - Roll Pct Breach
        /// </summary>
        RiskRollPctBreach = 286;

        /// <summary>
        ///  Invalid TargetCancelSender CompID
        /// </summary>
        InvalidTargetCancelSenderCompId = 255;

        /// <summary>
        ///  Risk - Roll GRMP Breach
        /// </summary>
        RiskRollGrmpBreach = 287;

        /// <summary>
        ///  Clear the Book Prev. Entered
        /// </summary>
        ClearTheBookPrevEntered = 256;

        /// <summary>
        ///  Risk - MM Arbitrage Breach
        /// </summary>
        RiskMmArbitrageBreach = 288;

        /// <summary>
        ///  Timer Expired - API Allocation
        /// </summary>
        TimerExpiredApiAllocation = 257;

        /// <summary>
        ///  Risk - MM Intrinsic Breach
        /// </summary>
        RiskMmIntrinsicBreach = 289;

        /// <summary>
        ///  Invalid Number of Quotes
        /// </summary>
        InvalidNumberOfQuotes = 258;

        /// <summary>
        ///  IDO Must Exist
        /// </summary>
        IdoMustExist = 290;

        /// <summary>
        ///  Invalid OrderID
        /// </summary>
        InvalidOrderId = 259;

        /// <summary>
        ///  Invalid Allocation tag <insert invalid tag number>
        /// </summary>
        InvalidAllocationTagInsertInvalidTagNumber = 291;

        /// <summary>
        ///  Risk Control Event
        /// </summary>
        RiskControlEvent = 260;

        /// <summary>
        ///  Invalid Trade tag <insert invalid tag number>
        /// </summary>
        InvalidTradeTagInsertInvalidTagNumber = 292;

        /// <summary>
        ///  TO Rejected
        /// </summary>
        ToRejected = 261;

        /// <summary>
        ///  Arbitrage Check
        /// </summary>
        ArbitrageCheck = 293;

        /// <summary>
        ///  Cancelled - Corporate Action
        /// </summary>
        CancelledCorporateAction = 262;

        /// <summary>
        ///  Intrinsic Value Check
        /// </summary>
        IntrinsicValueCheck = 294;

        /// <summary>
        ///  Too Late to Replace
        /// </summary>
        TooLateToReplace = 263;

        /// <summary>
        ///  Credit Debit Check
        /// </summary>
        CreditDebitCheck = 295;

        /// <summary>
        ///  Invalid RefDelta
        /// </summary>
        InvalidRefDelta = 264;

        /// <summary>
        ///  Invalid Risk User
        /// </summary>
        InvalidRiskUser = 296;

        /// <summary>
        ///  Invalid StockPrice
        /// </summary>
        InvalidStockPrice = 265;

        /// <summary>
        ///  Invalid Risk Entity
        /// </summary>
        InvalidRiskEntity = 297;

        /// <summary>
        ///  Reserved for future use
        /// </summary>
        ReservedForFutureUse = 266;

        /// <summary>
        ///  Invalid Flex Series Already Exists
        /// </summary>
        InvalidFlexSeriesAlreadyExists = 298;

        /// <summary>
        ///  Invalid TiedToStock
        /// </summary>
        InvalidTiedToStock = 267;

        /// <summary>
        ///  Invalid Flex Series Key
        /// </summary>
        InvalidFlexSeriesKey = 299;

        /// <summary>
        ///  Too Late to Allocate
        /// </summary>
        TooLateToAllocate = 268;

        /// <summary>
        ///  Invalid Clear the Book
        /// </summary>
        InvalidClearTheBook = 300;

        /// <summary>
        ///  Customer Interest on BBO
        /// </summary>
        CustomerInterestOnBbo = 269;

        /// <summary>
        ///  Invalid StockQty
        /// </summary>
        InvalidStockQty = 301;

        /// <summary>
        ///  IDO Cannot be Modified
        /// </summary>
        IdoCannotBeModified = 270;

        /// <summary>
        ///  Invalid PackageLinkID
        /// </summary>
        InvalidPackageLinkId = 302;

        /// <summary>
        ///  Cross Outside BBO
        /// </summary>
        CrossOutsideBbo = 271;

        /// <summary>
        ///  Complex Max Series Breach
        /// </summary>
        ComplexMaxSeriesBreach = 303;

        /// <summary>
        ///  Pending TO Approval
        /// </summary>
        PendingToApproval = 272;

        /// <summary>
        ///  Invalid Flex EOD tag <insert invalid tag number>
        /// </summary>
        InvalidFlexEodTagInsertInvalidTagNumber = 304;

        /// <summary>
        ///  Invalid LegOpenClose
        /// </summary>
        InvalidLegOpenClose = 273;

        /// <summary>
        ///  Invalid PercentagePrice
        /// </summary>
        InvalidPercentagePrice = 305;

        /// <summary>
        ///  Invalid RiskControlType
        /// </summary>
        InvalidRiskControlType = 274;

        /// <summary>
        ///  Invalid PercentageStrike
        /// </summary>
        InvalidPercentageStrike = 306;

        /// <summary>
        ///  Invalid RiskControlActivation
        /// </summary>
        InvalidRiskControlActivation = 275;

        /// <summary>
        ///  Cancel Remaining GTX
        /// </summary>
        CancelRemainingGtx = 307;

        /// <summary>
        ///  Invalid BreachActionRequest
        /// </summary>
        InvalidBreachActionRequest = 276;

        /// <summary>
        ///  Auction Not Running
        /// </summary>
        AuctionNotRunning = 308;

        /// <summary>
        ///  Invalid IOCAttribution
        /// </summary>
        InvalidIocAttribution = 277;

        /// <summary>
        ///  Invalid OrdStatus
        /// </summary>
        InvalidOrdStatus = 309;

        /// <summary>
        ///  Invalid RiskActionType
        /// </summary>
        InvalidRiskActionType = 278;

        /// <summary>
        ///  MMID Blocked
        /// </summary>
        MmidBlocked = 310;

        /// <summary>
        ///  Invalid USDLimit
        /// </summary>
        InvalidUsdLimit = 279;

        /// <summary>
        ///  Invalid CATIMID
        /// </summary>
        InvalidCatimid = 311;

        /// <summary>
        ///  IDO Already Exists
        /// </summary>
        IdoAlreadyExists = 280;

        /// <summary>
        ///  Risk - Rej ISO
        /// </summary>
        RiskRejIso = 312;

        /// <summary>
        ///  Invalid TimeLimit
        /// </summary>
        InvalidTimeLimit = 281;

        /// <summary>
        ///  Risk - Rej Mkt Orders
        /// </summary>
        RiskRejMktOrders = 313;

        /// <summary>
        ///  Invalid PercentageLimit
        /// </summary>
        InvalidPercentageLimit = 282;

        /// <summary>
        ///  Risk - Rej Early Trading
        /// </summary>
        RiskRejEarlyTrading = 314;

        /// <summary>
        ///  Invalid CountLimit
        /// </summary>
        InvalidCountLimit = 283;

        /// <summary>
        ///  Risk - Rej Early Trading
        /// </summary>
        RiskRejEarlyTrading = 315;

        /// <summary>
        ///  Risk - Rej Late Trading
        /// </summary>
        RiskRejLateTrading = 316;

        /// <summary>
        ///  Risk - Rej Restricted Symbol
        /// </summary>
        RiskRejRestrictedSymbol = 317;

        /// <summary>
        ///  Risk - Rej Sell Short for Symbol
        /// </summary>
        RiskRejSellShortForSymbol = 318;

        /// <summary>
        ///  Risk - Rej Sell Short Exempt for Symbol
        /// </summary>
        RiskRejSellShortExemptForSymbol = 319;

        /// <summary>
        ///  Risk - Rej Ord Max Qty Symbol ADV
        /// </summary>
        RiskRejOrdMaxQtySymbolAdv = 320;

        /// <summary>
        ///  Risk - Max Duplicative Ord
        /// </summary>
        RiskMaxDuplicativeOrd = 321;

        /// <summary>
        ///  Risk - Require LocateBroker
        /// </summary>
        RiskRequireLocateBroker = 322;

        /// <summary>
        ///  Invalid RiskRangeID
        /// </summary>
        InvalidRiskRangeId = 323;

        /// <summary>
        ///  Invalid RiskMinimumValue
        /// </summary>
        InvalidRiskMinimumValue = 324;

        /// <summary>
        ///  Invalid PriceScale
        /// </summary>
        InvalidPriceScale = 325;

        /// <summary>
        ///  Invalid - Max Risk Symbols Exceeded
        /// </summary>
        InvalidMaxRiskSymbolsExceeded = 326;

        /// <summary>
        ///  Invalid - Risk Settings Incomplete
        /// </summary>
        InvalidRiskSettingsIncomplete = 327;

        /// <summary>
        ///  Invalid AuctionID
        /// </summary>
        InvalidAuctionId = 328;

        /// <summary>
        ///  Repriced
        /// </summary>
        Repriced = 400;

        /// <summary>
        ///  Broker Reject
        /// </summary>
        BrokerReject = 800;

        /// <summary>
        ///  System full (CGA_RATE_EXCEEDED)
        /// </summary>
        SystemFullCgarateexceeded = 906;

        /// <summary>
        ///  Unknown Issue Encountered
        /// </summary>
        UnknownIssueEncountered = 999;

    }
}