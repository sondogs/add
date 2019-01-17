using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practice2
{
    public class Settings
    {
        [XmlAttribute] public int timerInterval = 0;
        [XmlAttribute] public string deserializeFrom = "XML";
    }
}
