using RedisSessionState_Poc;

namespace Znode.WebStore.Core.ViewModels
{
    public class ResponseData 
    {
        public string transactionIdField { get; set; }

        public System.DateTime transactionDateTimeField { get; set; }

        public string requestIdField { get; set; }

        public string referenceNumberField { get; set; }

        public string processorTransactionReferenceNumberField { get; set; }

        public string tokenField { get; set; }

        public decimal amountField { get; set; }

        public bool amountFieldSpecified { get; set; }

        public string authorizationNumberField { get; set; }

        public string authorizationCodeField { get; set; }

        public string aVResultField { get; set; }

        public string cVResultField { get; set; }

        public string responseField { get; set; }

        public string responseCodeField { get; set; }

        public string responseMessageField { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string TransactionId
        {
            get
            {
                return this.transactionIdField;
            }
            set
            {
                this.transactionIdField = value;
                this.RaisePropertyChanged("TransactionId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public System.DateTime TransactionDateTime
        {
            get
            {
                return this.transactionDateTimeField;
            }
            set
            {
                this.transactionDateTimeField = value;
                this.RaisePropertyChanged("TransactionDateTime");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string RequestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
                this.RaisePropertyChanged("RequestId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ReferenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
                this.RaisePropertyChanged("ReferenceNumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string ProcessorTransactionReferenceNumber
        {
            get
            {
                return this.processorTransactionReferenceNumberField;
            }
            set
            {
                this.processorTransactionReferenceNumberField = value;
                this.RaisePropertyChanged("ProcessorTransactionReferenceNumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
                this.RaisePropertyChanged("Token");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
                this.RaisePropertyChanged("Amount");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
                this.RaisePropertyChanged("AmountSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string AuthorizationNumber
        {
            get
            {
                return this.authorizationNumberField;
            }
            set
            {
                this.authorizationNumberField = value;
                this.RaisePropertyChanged("AuthorizationNumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string AuthorizationCode
        {
            get
            {
                return this.authorizationCodeField;
            }
            set
            {
                this.authorizationCodeField = value;
                this.RaisePropertyChanged("AuthorizationCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string AVResult
        {
            get
            {
                return this.aVResultField;
            }
            set
            {
                this.aVResultField = value;
                this.RaisePropertyChanged("AVResult");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string CVResult
        {
            get
            {
                return this.cVResultField;
            }
            set
            {
                this.cVResultField = value;
                this.RaisePropertyChanged("CVResult");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
                this.RaisePropertyChanged("Response");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string ResponseCode
        {
            get
            {
                return this.responseCodeField;
            }
            set
            {
                this.responseCodeField = value;
                this.RaisePropertyChanged("ResponseCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string ResponseMessage
        {
            get
            {
                return this.responseMessageField;
            }
            set
            {
                this.responseMessageField = value;
                this.RaisePropertyChanged("ResponseMessage");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
