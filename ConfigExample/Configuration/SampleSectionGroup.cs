using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfigExample.Configuration
{
    public class SampleSectionGroup : System.Configuration.ConfigurationSectionGroup
    {
        public SimpleSection Simple
        {
            get
            {
                return (SimpleSection)base.Sections["simple"];
            }
        }

        public ComplexSection Complex
        {
            get
            {
                return (ComplexSection)base.Sections["complex"];
            }
        }


    }
}
