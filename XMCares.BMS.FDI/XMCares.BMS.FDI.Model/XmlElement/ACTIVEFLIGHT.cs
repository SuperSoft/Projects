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
    public class ACTIVEFLIGHT
    {
        private int fLIGHTIDField;

        private string cARRIERField;

        private int fLIGHTField;

        private int oPDATEField;

        private int rEGISTRATIONField;

        private int aIRCRAFTTYPEField;

        private string fLIGHTNATUREField;

        private string fLIGHTTASKField;

        private string dIRECTIONField;

        private string sCHEDULETIMEField;

        private string eSTIMATETIMEField;

        private string aCTUALTIMEField;

        private int lINKEDFLIGHTIDField;

        private int cOMBINEFLIGHTIDField;

        private string fLIGHTSTATUSField;

        private string iRREGULARSTATUSField;

        private string vIPTYPEField;

        private string gENERALAGENTField;

        private string tERMINALField;

        private FLIGHTSEGMENTS fLIGHTSEGMENTSField;

        private CODESHARE cODESHAREField;

        private CHECKIN cHECKINField;

        private CHECKINCOUNTERALLOCATION cHECKINCOUNTERALLOCATIONField;

        private GATE gATEField;

        private GATEALLOCATION gATEALLOCATIONField;

        private string sTANDField;

        private CAROUSELALLOCATION cAROUSELALLOCATIONField;

        private IRREGULAR iRREGULARField;

        /// <remarks/>
        public int FLIGHTID
        {
            get
            {
                return this.fLIGHTIDField;
            }
            set
            {
                this.fLIGHTIDField = value;
            }
        }

        /// <remarks/>
        public string CARRIER
        {
            get
            {
                return this.cARRIERField;
            }
            set
            {
                this.cARRIERField = value;
            }
        }

        /// <remarks/>
        public int FLIGHT
        {
            get
            {
                return this.fLIGHTField;
            }
            set
            {
                this.fLIGHTField = value;
            }
        }

        /// <remarks/>
        public int OPDATE
        {
            get
            {
                return this.oPDATEField;
            }
            set
            {
                this.oPDATEField = value;
            }
        }

        /// <remarks/>
        public int REGISTRATION
        {
            get
            {
                return this.rEGISTRATIONField;
            }
            set
            {
                this.rEGISTRATIONField = value;
            }
        }

        /// <remarks/>
        public int AIRCRAFTTYPE
        {
            get
            {
                return this.aIRCRAFTTYPEField;
            }
            set
            {
                this.aIRCRAFTTYPEField = value;
            }
        }

        /// <remarks/>
        public string FLIGHTNATURE
        {
            get
            {
                return this.fLIGHTNATUREField;
            }
            set
            {
                this.fLIGHTNATUREField = value;
            }
        }

        /// <remarks/>
        public string FLIGHTTASK
        {
            get
            {
                return this.fLIGHTTASKField;
            }
            set
            {
                this.fLIGHTTASKField = value;
            }
        }

        /// <remarks/>
        public string DIRECTION
        {
            get
            {
                return this.dIRECTIONField;
            }
            set
            {
                this.dIRECTIONField = value;
            }
        }

        /// <remarks/>
        public string SCHEDULETIME
        {
            get
            {
                return this.sCHEDULETIMEField;
            }
            set
            {
                this.sCHEDULETIMEField = value;
            }
        }

        /// <remarks/>
        public string ESTIMATETIME
        {
            get
            {
                return this.eSTIMATETIMEField;
            }
            set
            {
                this.eSTIMATETIMEField = value;
            }
        }

        /// <remarks/>
        public string ACTUALTIME
        {
            get
            {
                return this.aCTUALTIMEField;
            }
            set
            {
                this.aCTUALTIMEField = value;
            }
        }

        /// <remarks/>
        public int LINKEDFLIGHTID
        {
            get
            {
                return this.lINKEDFLIGHTIDField;
            }
            set
            {
                this.lINKEDFLIGHTIDField = value;
            }
        }

        /// <remarks/>
        public int COMBINEFLIGHTID
        {
            get
            {
                return this.cOMBINEFLIGHTIDField;
            }
            set
            {
                this.cOMBINEFLIGHTIDField = value;
            }
        }

        /// <remarks/>
        public string FLIGHTSTATUS
        {
            get
            {
                return this.fLIGHTSTATUSField;
            }
            set
            {
                this.fLIGHTSTATUSField = value;
            }
        }

        /// <remarks/>
        public string IRREGULARSTATUS
        {
            get
            {
                return this.iRREGULARSTATUSField;
            }
            set
            {
                this.iRREGULARSTATUSField = value;
            }
        }

        /// <remarks/>
        public string VIPTYPE
        {
            get
            {
                return this.vIPTYPEField;
            }
            set
            {
                this.vIPTYPEField = value;
            }
        }

        /// <remarks/>
        public string GENERALAGENT
        {
            get
            {
                return this.gENERALAGENTField;
            }
            set
            {
                this.gENERALAGENTField = value;
            }
        }

        /// <remarks/>
        public string TERMINAL
        {
            get
            {
                return this.tERMINALField;
            }
            set
            {
                this.tERMINALField = value;
            }
        }

        /// <remarks/>
        public FLIGHTSEGMENTS FLIGHTSEGMENTS
        {
            get
            {
                return this.fLIGHTSEGMENTSField;
            }
            set
            {
                this.fLIGHTSEGMENTSField = value;
            }
        }

        /// <remarks/>
        public CODESHARE CODESHARE
        {
            get
            {
                return this.cODESHAREField;
            }
            set
            {
                this.cODESHAREField = value;
            }
        }

        /// <remarks/>
        public CHECKIN CHECKIN
        {
            get
            {
                return this.cHECKINField;
            }
            set
            {
                this.cHECKINField = value;
            }
        }

        /// <remarks/>
        public CHECKINCOUNTERALLOCATION CHECKINCOUNTERALLOCATION
        {
            get
            {
                return this.cHECKINCOUNTERALLOCATIONField;
            }
            set
            {
                this.cHECKINCOUNTERALLOCATIONField = value;
            }
        }

        /// <remarks/>
        public GATE GATE
        {
            get
            {
                return this.gATEField;
            }
            set
            {
                this.gATEField = value;
            }
        }

        /// <remarks/>
        public GATEALLOCATION GATEALLOCATION
        {
            get
            {
                return this.gATEALLOCATIONField;
            }
            set
            {
                this.gATEALLOCATIONField = value;
            }
        }

        /// <remarks/>
        public string STAND
        {
            get
            {
                return this.sTANDField;
            }
            set
            {
                this.sTANDField = value;
            }
        }

        /// <remarks/>
        public CAROUSELALLOCATION CAROUSELALLOCATION
        {
            get
            {
                return this.cAROUSELALLOCATIONField;
            }
            set
            {
                this.cAROUSELALLOCATIONField = value;
            }
        }

        /// <remarks/>
        public IRREGULAR IRREGULAR
        {
            get
            {
                return this.iRREGULARField;
            }
            set
            {
                this.iRREGULARField = value;
            }
        }
    }
}
