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
    public class CHECKINCOUNTER
    {
        private string aCTIONField;

        private int aLOIDField;

        private string cOUNTERCODEField;

        private string cOUNTERMODEField;

        private string sERVICETYPEField;

        private string sCHEDULEOPENField;

        private string sCHEDULECLOSEField;

        private string eSTIMATEOPENField;

        private string eSTIMATECLOSEField;

        private string aCTUALOPENField;

        private string aCTUALCLOSEField;

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
        public int ALOID
        {
            get
            {
                return this.aLOIDField;
            }
            set
            {
                this.aLOIDField = value;
            }
        }

        /// <remarks/>
        public string COUNTERCODE
        {
            get
            {
                return this.cOUNTERCODEField;
            }
            set
            {
                this.cOUNTERCODEField = value;
            }
        }

        /// <remarks/>
        public string COUNTERMODE
        {
            get
            {
                return this.cOUNTERMODEField;
            }
            set
            {
                this.cOUNTERMODEField = value;
            }
        }

        /// <remarks/>
        public string SERVICETYPE
        {
            get
            {
                return this.sERVICETYPEField;
            }
            set
            {
                this.sERVICETYPEField = value;
            }
        }

        /// <remarks/>
        public string SCHEDULEOPEN
        {
            get
            {
                return this.sCHEDULEOPENField;
            }
            set
            {
                this.sCHEDULEOPENField = value;
            }
        }

        /// <remarks/>
        public string SCHEDULECLOSE
        {
            get
            {
                return this.sCHEDULECLOSEField;
            }
            set
            {
                this.sCHEDULECLOSEField = value;
            }
        }

        /// <remarks/>
        public string ESTIMATEOPEN
        {
            get
            {
                return this.eSTIMATEOPENField;
            }
            set
            {
                this.eSTIMATEOPENField = value;
            }
        }

        /// <remarks/>
        public string ESTIMATECLOSE
        {
            get
            {
                return this.eSTIMATECLOSEField;
            }
            set
            {
                this.eSTIMATECLOSEField = value;
            }
        }

        /// <remarks/>
        public string ACTUALOPEN
        {
            get
            {
                return this.aCTUALOPENField;
            }
            set
            {
                this.aCTUALOPENField = value;
            }
        }

        /// <remarks/>
        public string ACTUALCLOSE
        {
            get
            {
                return this.aCTUALCLOSEField;
            }
            set
            {
                this.aCTUALCLOSEField = value;
            }
        }
    }
}
