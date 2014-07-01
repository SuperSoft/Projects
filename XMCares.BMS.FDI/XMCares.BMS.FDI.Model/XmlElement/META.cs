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
    public class META
    {
        private string sENDSYSTEMField;

        private string dESTINATIONSYSTEMField;

        private string sENDTIMEField;

        private int sEQUENCENUMBERField;

        private string mESSAGETYPEField;

        private string mESSAGESUBTYPEField;

        private string oRIGINSYSTEMField;

        private string oRIGINSENDTIMEField;

        /// <remarks/>
        public string SENDSYSTEM
        {
            get
            {
                return this.sENDSYSTEMField;
            }
            set
            {
                this.sENDSYSTEMField = value;
            }
        }

        /// <remarks/>
        public string DESTINATIONSYSTEM
        {
            get
            {
                return this.dESTINATIONSYSTEMField;
            }
            set
            {
                this.dESTINATIONSYSTEMField = value;
            }
        }

        /// <remarks/>
        public string SENDTIME
        {
            get
            {
                return this.sENDTIMEField;
            }
            set
            {
                this.sENDTIMEField = value;
            }
        }

        /// <remarks/>
        public int SEQUENCENUMBER
        {
            get
            {
                return this.sEQUENCENUMBERField;
            }
            set
            {
                this.sEQUENCENUMBERField = value;
            }
        }

        /// <remarks/>
        public string MESSAGETYPE
        {
            get
            {
                return this.mESSAGETYPEField;
            }
            set
            {
                this.mESSAGETYPEField = value;
            }
        }

        /// <remarks/>
        public string MESSAGESUBTYPE
        {
            get
            {
                return this.mESSAGESUBTYPEField;
            }
            set
            {
                this.mESSAGESUBTYPEField = value;
            }
        }

        /// <remarks/>
        public string ORIGINSYSTEM
        {
            get
            {
                return this.oRIGINSYSTEMField;
            }
            set
            {
                this.oRIGINSYSTEMField = value;
            }
        }

        /// <remarks/>
        public string ORIGINSENDTIME
        {
            get
            {
                return this.oRIGINSENDTIMEField;
            }
            set
            {
                this.oRIGINSENDTIMEField = value;
            }
        }
    }
}
