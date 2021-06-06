using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace A9servis
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Dictionary<string, string> paroviSlova = new Dictionary<string, string>
        {
            {"Џ","Dž"},
            {"Љ","Lj"},
            {"Њ","Nj"},
            {"Ш","Š"},
            {"Ђ","Đ"},
            {"А","A"},
            {"Б","B"},
            {"В","V"},
            {"Г","G"},
            {"Д","D"},
            
            {"Е","E"},
            {"Ж","Ž"},
            {"З","Z"},
            {"И","I"},
            {"Ј","J"},
            {"К","K"},
            {"Л","L"},
            
            {"М","M"},
            {"Н","N"},
            
            {"О","O"},
            {"П","P"},
            {"Р","R"},
            {"С","S"},
            {"Т","T"},
            {"Ћ","Ć"},
            {"У","U"},
            {"Ф","F"},
            {"Х","H"},
            {"Ц","C"},
            {"Ч","Č"},
            
           
        };
        [WebMethod]
        public string CirilicaULatinicu(string tekst)
        {
            string prevod = tekst;
            foreach (var item in paroviSlova)
            {
                prevod = prevod.Replace(item.Key, item.Value);
                prevod = prevod.Replace(item.Key.ToLower(), item.Value.ToLower());
            }
            return prevod;
        }
        [WebMethod]
        public string LatinicaUCirilicu(string tekst)
        {
            string prevod = tekst;
            foreach (var item in paroviSlova)
            {
                prevod = prevod.Replace(item.Value, item.Key);
                prevod = prevod.Replace(item.Value.ToLower(), item.Key.ToLower());
            }
            return prevod;
        }
    }
}
