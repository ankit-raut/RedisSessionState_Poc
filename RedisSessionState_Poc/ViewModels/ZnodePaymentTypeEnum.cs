namespace RedisSessionState_Poc
{
    public enum ZNodePaymentTypeEnum
    {
        /// <summary>
        /// Payment type is credit card.
        /// </summary>
        CREDIT_CARD,

        /// <summary>
        /// Payment type is Purchase Order
        /// </summary>
        PURCHASE_ORDER,

        /// <summary>
        /// Payment type is PayPal
        /// </summary>
        PAYPAL_EXPRESS,

        /// <summary>
        /// Payment type is COD
        /// </summary>
        COD,

        /// <summary>
        /// Payment type is Amazon
        /// </summary>
        AMAZON_PAY
    }
}
