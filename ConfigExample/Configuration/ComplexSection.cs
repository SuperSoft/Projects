using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ConfigExample.Configuration
{
    public class ComplexSection : ConfigurationSection
    {
        [ConfigurationProperty("height", IsRequired = true)]
        public int Height
        {
            get
            {
                return (int)base["height"];
            }
            set
            {
                base["height"] = value;
            }
        }

        [ConfigurationProperty("child", IsDefaultCollection = false)]
        public ChildSection Child
        {
            get
            {
                return (ChildSection)base["child"];
            }
            set
            {
                base["child"] = value;
            }
        }

        [ConfigurationProperty("children", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ChildSection), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap, RemoveItemName = "remove")]
        public Children Children
        {
            get
            {
                return (Children)base["children"];
            }
            set
            {
                base["children"] = value;
            }
        }

        [ConfigurationProperty("NVs", IsDefaultCollection = false)]
        public System.Configuration.NameValueConfigurationCollection NVs
        {
            get
            {
                return (NameValueConfigurationCollection)base["NVs"];
            }
            set
            {
                base["NVs"] = value;
            }
        }
    }

    public class Children : ConfigurationElementCollection
    {
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ChildSection)element).FirstName;
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ChildSection();
        }

        public ChildSection this[int i]
        {
            get
            {
                return (ChildSection)base.BaseGet(i);
            }
        }

        public ChildSection this[string key]
        {
            get
            {
                return (ChildSection)base.BaseGet(key);
            }
        }

    }

    public class ChildSection : ConfigurationElement
    {
        [ConfigurationProperty("firstName", IsRequired = true, IsKey = true)]
        public string FirstName
        {
            get
            {
                return (string)base["firstName"];
            }
            set
            {
                base["firstName"] = value;
            }
        }

        [ConfigurationProperty("lastName", IsRequired = true)]
        public string LastName
        {
            get
            {
                return (string)base["lastName"];
            }
            set
            {
                base["lastName"] = value;
            }
        }
    }
}
