using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMCares.BMS.FDI.Common
{
    public class XmlSerializeHelper
    {
        /// <summary>
        /// 解析正则表达式，获取子类型
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string GetValueByRegex(string regex, string data)
        {
            Regex RegexData = new Regex(regex);
            Match MatchResult = RegexData.Match(data);
            if (MatchResult.Success)
            {
                return MatchResult.Result("$1");
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 序列化对象为XML
        /// </summary>
        /// <param name="type"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string Serialize(Type type, object o)
        {
            string xmlString = string.Empty;
            try
            {
                XmlSerializer xs = new XmlSerializer(type);
                MemoryStream ms = new MemoryStream();
                xs.Serialize(ms, o);
                ms.Seek(0, SeekOrigin.Begin);
                StreamReader sr = new StreamReader(ms);
                xmlString = sr.ReadToEnd();
                ms.Close();
            }
            catch (Exception ex)
            {
            }
            return xmlString;
        }

        /// <summary>
        /// 序列化对象为XML
        /// </summary>
        /// <typeparam name="TRootElement"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string Serialize<TRootElement>(TRootElement o)
        {
            return Serialize(typeof(TRootElement), o);
        }

        /// <summary>
        /// 反序列化XML为对象
        /// </summary>
        /// <param name="type"></param>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static object Deserialize(Type type, string xml)
        {
            object rootElement = new object();
            try
            {
                XmlSerializer xs = new XmlSerializer(type);
                MemoryStream ms = new MemoryStream();
                StreamWriter sw = new StreamWriter(ms);
                sw.Write(xml);
                sw.Flush();
                ms.Seek(0, SeekOrigin.Begin);
                rootElement = xs.Deserialize(ms);
                ms.Close();
            }
            catch (Exception ex)
            {
            }
            return rootElement;
        }

        /// <summary>
        /// 反序列化XML为对象
        /// </summary>
        /// <typeparam name="TRootElement"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static TRootElement Deserialize<TRootElement>(string xml)
        {
            return (TRootElement)Deserialize(typeof(TRootElement), xml);
        }
    }
}
