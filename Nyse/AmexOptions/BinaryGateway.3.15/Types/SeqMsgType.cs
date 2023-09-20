namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Seq Msg Type: Code identifying this message type
    /// </summary>
    public enum SeqMsgType : ushort
    {
        /// <summary>
        ///  This message may be sent by the firm to change their configuration settings for a given gateway session, as defined by its Username
        /// </summary>
        SessionConfigurationRequestMessage = 0x0220,

        /// <summary>
        ///  This message may be sent by the firm to change their configuration settings for a given gateway session, as defined by its Username
        /// </summary>
        SequencedFiller = 0x0282,

        /// <summary>
        ///  This message type is used as both a New Order message or a Cancel/Replacement message, as well as in conjunction with the New Order Cross message
        /// </summary>
        OrderRequest = 0x0248,

        /// <summary>
        ///  This message is used to cancel a single targeted order including complex orders
        /// </summary>
        OrderCancelRequest = 0x0250,

        /// <summary>
        ///  This message may be sent by the firm to change their configuration settings for a given gateway session, as defined by its Username
        /// </summary>
        OrderModifyRequest = 0x0282,

        /// <summary>
        ///  This message may be sent by an Options Market Maker to enter up to 20 Quote messages at once
        /// </summary>
        NewBulkQuote = 0x0243,

        /// <summary>
        ///  This message can be used to enter cross orders
        /// </summary>
        NewOrderCross = 0x0222,

        /// <summary>
        ///  This message is used to bulk cancel multiple orders/Market Maker Quotes based on the combination of criteria specified in the message
        /// </summary>
        BulkCancelRequest = 0x0223,

        /// <summary>
        ///  This message allows firms using Pillar Risk Controls to set/update the risk configurations of Risk Entities for which they have “write” entitlements
        /// </summary>
        RiskLimitUpdateRequest = 0x0330,

        /// <summary>
        ///  This message allows firms using Pillar Risk Controls to query Risk Entities for current configurations/calculations/status, invoke Kill Switch actions, and Approve Reinstatement following a breach with “Block” instructions
        /// </summary>
        RiskActionRequest = 0x0331,

        /// <summary>
        ///  This message type is used to create a new complex series as defined in the message
        /// </summary>
        NewComplexSeriesRequest = 0x0357,

        /// <summary>
        ///  This message is published for each Underlying symbol for which a gateway session is configured to trade
        /// </summary>
        UnderlyingSymbolReferenceData = 0x0233,

        /// <summary>
        ///  This message is published for each security traded on the market for which a gateway session is configured to trade
        /// </summary>
        SequencedFiller = 0X0234,

        /// <summary>
        ///  This message defines a single MPV Class by name and Identification number, and provides attributes belonging to that class
        /// </summary>
        MinimumPriceVariantClassReferenceData = 0x0230,

        /// <summary>
        ///  This message defines one or more MPV Levels within a single MPV Class
        /// </summary>
        MinimumPriceVariantLevelReferenceData = 0x0231,

        /// <summary>
        ///  An instance of this message is provided, unsolicited, at start of day for each MPID configured on a gateway session
        /// </summary>
        MpidConfiguration = 0x0272,

        /// <summary>
        ///  This message is provided to Market Makers for each of their appointed underlying symbols
        /// </summary>
        OptionsMarketMakerSymbolAppointmentReferenceData = 0x0833,

        /// <summary>
        ///  This message is provided, unsolicited, at start of day
        /// </summary>
        SessionConfigurationAcknowledgement = 0x0221,

        /// <summary>
        ///  This message is provided by the Exchange in response to an Order/Cancel Replace Request or New Order Cross
        /// </summary>
        OrderAcknowledgement = 0x026,

        /// <summary>
        ///  This message may be sent by the firm to change their configuration settings for a given gateway session, as defined by its Username
        /// </summary>
        BulkQuoteAcknowledgment = 0x0294,

        /// <summary>
        ///  This message is used as a Modify Request Acknowledgement, a Cancel Request Acknowledgment, a UROUT, and a Billable Cancel
        /// </summary>
        OrderRequestAcknowledgment = 0x0278,

        /// <summary>
        ///  This message is sent unsolicited by the Exchange to notify the firm of a Reserve Order replenishment event
        /// </summary>
        OrderPriorityUpdateAcknowledgment = 0x0268,

        /// <summary>
        ///  This message type will be returned on executions for Options orders and indicates whether an order has been partially or entirely filled
        /// </summary>
        ExecutionReport = 0x0295,

        /// <summary>
        ///  This message is sent as a result of a report bust or correction
        /// </summary>
        TradeBustOrCorrect = 0x0293,

        /// <summary>
        ///  This message informs the firm that a request has been rejected
        /// </summary>
        ApplicationLayerReject = 0x0267,

        /// <summary>
        ///  This message may be sent by the firm to change their configuration settings for a given gateway session, as defined by its Username
        /// </summary>
        RiskControlAcknowledgement = 0x0332,

        /// <summary>
        ///  this message provides notification of threshold, breach, reinstatement and kill switch events
        /// </summary>
        RiskControlAlert = 0x0333,

        /// <summary>
        ///  This message may be sent by the firm to change their configuration settings for a given gateway session, as defined by its Username
        /// </summary>
        ComplexSeriesRequestAcknowledgement = 0x0358,

    }
}