using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml;
using System.Xml.Serialization;


public class Skills {
    [XmlAttribute("CodSkill")]
    public string codSkill;
  //  [XmlElement("TipoSkill")]
  //  public string tipoSkill;
    // 0 - Ataque primario 1- ataque secundario 2 - skill  3 - Skill de momvimento

    [XmlElement("CodClasse")]
    public string codClasse;

    [XmlElement("DescSkill")]
    public string descSkill;




}
