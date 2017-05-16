using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml;
using System.Xml.Serialization;

public class Classes{

    [XmlAttribute("CodeClasse")]
    public string clCodClass;
    [XmlElement("NomeClasse")]
    public string clName;
    [XmlElement("Ativo")]
    public bool isActivated;
    
    
}
