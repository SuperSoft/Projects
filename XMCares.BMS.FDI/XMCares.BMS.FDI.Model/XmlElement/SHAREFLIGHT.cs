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
    public class SHAREFLIGHT
    {

        private string aCTIONField;

        private int fLIGHTSHAREIDField;

        private int sEGMENTIDField;

        private string cARRIERField;

        private string sHAREFLIGHTNOField;

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
        public int FLIGHTSHAREID
        {
            get
            {
                return this.fLIGHTSHAREIDField;
            }
            set
            {
                this.fLIGHTSHAREIDField = value;
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

        [System.Xml.Serialization.XmlElementAttribute("SHAREFLIGHT")]
        public string SHAREFLIGHTNO
        {
            get
            {
                return this.sHAREFLIGHTNOField;
            }
            set
            {
                this.sHAREFLIGHTNOField = value;
            }
        }
    }
}
