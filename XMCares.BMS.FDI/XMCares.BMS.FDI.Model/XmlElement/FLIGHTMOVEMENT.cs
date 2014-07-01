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
    public class FLIGHTMOVEMENT
    {
        private string aCTIONField;

        private ACTIVEFLIGHT aCTIVEFLIGHTField;

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
        public ACTIVEFLIGHT ACTIVEFLIGHT
        {
            get
            {
                return this.aCTIVEFLIGHTField;
            }
            set
            {
                this.aCTIVEFLIGHTField = value;
            }
        }
    }
}
