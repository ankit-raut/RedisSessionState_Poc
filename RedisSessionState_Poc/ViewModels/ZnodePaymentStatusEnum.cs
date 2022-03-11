namespace RedisSessionState_Poc
{
    public enum ZnodePaymentStatusEnum
    {
        /// <summary>
        /// Credit card Authorized
        /// </summary>
        CC_AUTHORIZED,

        /// <summary>
        /// Credit Card Captured.
        /// </summary>
        CC_CAPTURED,

        /// <summary>
        /// Credit Card Declined
        /// </summary>
        CC_DECLINED,

        /// <summary>
        /// Credit Card Refunded
        /// </summary>
        CC_REFUNDED,

        /// <summary>
        /// Credit Card Payment was Voided
        /// </summary>
        CC_VOIDED,

        /// <summary>
        /// Credit Card Payment Pending
        /// </summary>
        CC_PENDING,

        /// <summary>
        /// Purchase Order Pending
        /// </summary>
        PO_PENDING,

        /// <summary>
        /// Purchase Order Received
        /// </summary>
        PO_RECEIVED,

        /// <summary>
        /// COD Pending
        /// </summary>
        COD_PENDING,

        /// <summary>
        /// COD Received
        /// </summary>
        COD_RECEIVED,
    }
}
