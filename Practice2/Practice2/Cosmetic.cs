using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practice2
{
    public class Cosmetic
    {
        [XmlAttribute] public string name = "";
        [XmlElement] public string type = "";
        [XmlAttribute] public int price = 0;

        public Cosmetic()
        {
            name = "";
            type = "";
            price = 0;
        }
    }
}
