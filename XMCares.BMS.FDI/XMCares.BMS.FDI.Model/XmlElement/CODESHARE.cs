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
    public class CODESHARE
    {

        private List<SHAREFLIGHT> sHAREFLIGHTField;

        /// <remarks/>
        public List<SHAREFLIGHT> SHAREFLIGHT
        {
            get
            {
                return this.sHAREFLIGHTField;
            }
            set
            {
                this.sHAREFLIGHTField = value;
            }
        }
    }
}
