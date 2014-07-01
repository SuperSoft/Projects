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
    public class CHECKIN
    {
        private int cHECKINTIMETABLEIDField;

        private string cHECKINGROUPField;

        private string sCHEDULECHECKINOPENField;

        private string sCHEDULECHECKINCLOSEField;

        private string eSTIMATECHECKINOPENField;

        private string eSTIMATECHECKINCLOSEField;

        private string aCTUALCHECKINOPENField;

        private string aCTUALCHECKINCLOSEField;

        /// <remarks/>
        public int CHECKINTIMETABLEID
        {
            get
            {
                return this.cHECKINTIMETABLEIDField;
            }
            set
            {
                this.cHECKINTIMETABLEIDField = value;
            }
        }

        /// <remarks/>
        public string CHECKINGROUP
        {
            get
            {
                return this.cHECKINGROUPField;
            }
            set
            {
                this.cHECKINGROUPField = value;
            }
        }

        /// <remarks/>
        public string SCHEDULECHECKINOPEN
        {
            get
            {
                return this.sCHEDULECHECKINOPENField;
            }
            set
            {
                this.sCHEDULECHECKINOPENField = value;
            }
        }

        /// <remarks/>
        public string SCHEDULECHECKINCLOSE
        {
            get
            {
                return this.sCHEDULECHECKINCLOSEField;
            }
            set
            {
                this.sCHEDULECHECKINCLOSEField = value;
            }
        }

        /// <remarks/>
        public string ESTIMATECHECKINOPEN
        {
            get
            {
                return this.eSTIMATECHECKINOPENField;
            }
            set
            {
                this.eSTIMATECHECKINOPENField = value;
            }
        }

        /// <remarks/>
        public string ESTIMATECHECKINCLOSE
        {
            get
            {
                return this.eSTIMATECHECKINCLOSEField;
            }
            set
            {
                this.eSTIMATECHECKINCLOSEField = value;
            }
        }

        /// <remarks/>
        public string ACTUALCHECKINOPEN
        {
            get
            {
                return this.aCTUALCHECKINOPENField;
            }
            set
            {
                this.aCTUALCHECKINOPENField = value;
            }
        }

        /// <remarks/>
        public string ACTUALCHECKINCLOSE
        {
            get
            {
                return this.aCTUALCHECKINCLOSEField;
            }
            set
            {
                this.aCTUALCHECKINCLOSEField = value;
            }
        }
    }
}
