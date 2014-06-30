using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XMCares.BMS.FDI.Common
{
    public class ObjectFactory
    {
        private static IUnityContainer container = null;

        private static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = new UnityContainer();
                    UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
                    section.Configure(container);
                }
                return container;
            }
        }

        public static TService GetService<TService>()
        {
            return Container.Resolve<TService>();
        }

        public static TService GetService<TService>(string name)
        {
            return Container.Resolve<TService>(name);
        }

        public static object GetObject(string className, string assemblyName)
        {
            object o = null;
            string dllName = assemblyName + ".dll";
            //判断文件是否存在
            if (File.Exists(dllName))
            {
                Assembly assembly = Assembly.Load(assemblyName);
                o = assembly.CreateInstance(className);
            }
            return o;
        }

        public static TObject GetObject<TObject>(string className, string assemblyName)
        {
            return (TObject)GetObject(className, assemblyName);
        }
    }
}
