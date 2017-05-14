using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;


public class Slots{

    [XmlAttribute("SlotNumber")]
    public string numSlot;

    [XmlElement("Active")]
    public bool isActive;

    [XmlElement("Name")]
    public string plName;

    [XmlElement("Class")]
    public int plClass;

    [XmlElement("Level")]
    public int plLevel;

    [XmlElement("Experience")]
    public int plExperience;


    [XmlElement("Skills")]
    public string skills;


    
}
