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
    public class ALTERNATE
    {
        private string aCTIONField;

        private int aLTERNATEFLIGHTIDField;

        private string aLTERNATEAIRPORTField;

        private string eSTIMATEDEPARTURETIMEField;

        private string aCTUALDEPARTURETIMEField;

        private string eSTIMATEARRIVALTIMEField;

        private string aCTUALARRIVALTIMEField;

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
        public int ALTERNATEFLIGHTID
        {
            get
            {
                return this.aLTERNATEFLIGHTIDField;
            }
            set
            {
                this.aLTERNATEFLIGHTIDField = value;
            }
        }

        /// <remarks/>
        public string ALTERNATEAIRPORT
        {
            get
            {
                return this.aLTERNATEAIRPORTField;
            }
            set
            {
                this.aLTERNATEAIRPORTField = value;
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
    }
}
