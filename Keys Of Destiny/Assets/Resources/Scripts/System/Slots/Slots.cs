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


    [XmlElement("Ataque1")]
    public string ataque1;

    [XmlElement("Ataque2")]
    public string ataque2;

    [XmlElement("Skill1")]
    public string skill1;

    [XmlElement("Skill2")]
    public string skill2;





}
