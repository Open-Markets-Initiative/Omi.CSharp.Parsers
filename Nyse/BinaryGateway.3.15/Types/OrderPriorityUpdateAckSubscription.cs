namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Order Priority Update Ack Subscription: 0 = Not subscribed to receive the unsolicited “Order Priority Update Ack” message or unsolicited “Repricing Ack” message on the Session.
    /// </summary>
    public enum OrderPriorityUpdateAckSubscription : byte
    {
        /// <summary>
        ///  Unsolicited Order Priority Update Ack
        /// </summary>
        UnsolicitedOrderPriorityUpdateAck = 1;

        /// <summary>
        ///  Unsolicited Order Priority Update Ack And Unsolicited Repricing Ack
        /// </summary>
        UnsolicitedOrderPriorityUpdateAckAndUnsolicitedRepricingAck = 2;

    }
}