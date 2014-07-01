using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMCares.BMS.FDI.Model
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "schema.aiis.maiis.iport")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "schema.aiis.maiis.iport", IsNullable = false)]
    public class FLIGHTSEGMENT
    {
        private string aCTIONField;

        private int sEGMENTIDField;

        private int sEGMENTSINDEXField;

        private string oRIGINField;

        private string dESTINATIONField;

        private string sCHEDULEDEPARTURETIMEField;

        private string sCHEDULEARRIVALTIMEField;

        private string eSTIMATEDEPARTURETIMEField;

        private string eSTIMATEARRIVALTIMEField;

        private string aCTUALDEPARTURETIMEField;

        private string aCTUALARRIVALTIMEField;

        private int aCTUALSEGMENTField;

        /// <remarks/>
        public string ACTION
        {
            get
            {
                return this.aCTIONField;
            }
            set
            {
                this.aCTIONField = value;
            }
        }

        /// <remarks/>
        public int SEGMENTID
        {
            get
            {
                return this.sEGMENTIDField;
            }
            set
            {
                this.sEGMENTIDField = value;
            }
        }

        /// <remarks/>
        public int SEGMENTSINDEX
        {
            get
            {
                return this.sEGMENTSINDEXField;
            }
            set
            {
                this.sEGMENTSINDEXField = value;
            }
        }

        /// <remarks/>
        public string ORIGIN
        {
            get
            {
                return this.oRIGINField;
            }
            set
            {
                this.oRIGINField = value;
            }
        }

        /// <remarks/>
        public string DESTINATION
        {
            get
            {
                return this.dESTINATIONField;
            }
            set
            {
                this.dESTINATIONField = value;
            }
        }

        /// <remarks/>
        public string SCHEDULEDEPARTURETIME
        {
            get
            {
                return this.sCHEDULEDEPARTURETIMEField;
            }
            set
            {
                this.sCHEDULEDEPARTURETIMEField = value;
            }
        }

        /// <remarks/>
        public string SCHEDULEARRIVALTIME
        {
            get
            {
                return this.sCHEDULEARRIVALTIMEField;
            }
            set
            {
                this.sCHEDULEARRIVALTIMEField = value;
            }
        }

        /// <remarks/>
        public string ESTIMATEDEPARTURETIME
        {
            get
            {
                return this.eSTIMATEDEPARTURETIMEField;
            }
            set
            {
                this.eSTIMATEDEPARTURETIMEField = value;
            }
        }

        /// <remarks/>
        public string ESTIMATEARRIVALTIME
        {
            get
            {
                return this.eSTIMATEARRIVALTIMEField;
            }
            set
            {
                this.eSTIMATEARRIVALTIMEField = value;
            }
        }

        /// <remarks/>
        public string ACTUALDEPARTURETIME
        {
            get
            {
                return this.aCTUALDEPARTURETIMEField;
            }
            set
            {
                this.aCTUALDEPARTURETIMEField = value;
            }
        }

        /// <remarks/>
        public string ACTUALARRIVALTIME
        {
            get
            {
                return this.aCTUALARRIVALTIMEField;
            }
            set
            {
                this.aCTUALARRIVALTIMEField = value;
            }
        }

        /// <remarks/>
        public int ACTUALSEGMENT
        {
            get
            {
                return this.aCTUALSEGMENTField;
            }
            set
            {
                this.aCTUALSEGMENTField = value;
            }
        }
    }
}
