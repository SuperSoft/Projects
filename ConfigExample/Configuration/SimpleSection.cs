using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ConfigExample.Configuration
{
    public class SimpleSection:System.Configuration.ConfigurationSection
    {
        [ConfigurationProperty("maxValue",IsRequired=false,DefaultValue=Int32.MaxValue)]
        public int MaxValue
        {
            get
            {
                return  (int)base["maxValue"];
            }
            set
            {
                base["maxValue"] = value;
            }
        }

        [ConfigurationProperty("minValue",IsRequired=false,DefaultValue=1)]
        public int MinValue
        {
            get { return (int) base["minValue"];}
            set { base["minValue"] = value; }
        }


        [ConfigurationProperty("enabled",IsRequired=false,DefaultValue=true)]
        public bool Enable
        {
            get
            {
                return (bool)base["enabled"];
            }
            set
            {
                base["enabled"] = value;
            }
        }
    }
}
