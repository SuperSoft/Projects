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
    public class IRREGULAR
    {
        private string aCTIONField;

        private string iRREGULARSTATUSField;

        private int iRREGULARCODEField;

        private int pUBLISHIRREGULARCODEField;

        private ALTERNATE aLTERNATEField;

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
        public int IRREGULARCODE
        {
            get
            {
                return this.iRREGULARCODEField;
            }
            set
            {
                this.iRREGULARCODEField = value;
            }
        }

        /// <remarks/>
        public int PUBLISHIRREGULARCODE
        {
            get
            {
                return this.pUBLISHIRREGULARCODEField;
            }
            set
            {
                this.pUBLISHIRREGULARCODEField = value;
            }
        }

        /// <remarks/>
        public ALTERNATE ALTERNATE
        {
            get
            {
                return this.aLTERNATEField;
            }
            set
            {
                this.aLTERNATEField = value;
            }
        }
    }
}
