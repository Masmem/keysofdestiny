using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("SlotsCollection")]
public class SlotsContainer {


    [XmlArray("Slots")]
    [XmlArrayItem("Slot")]
    public List<Slots> slots = new List<Slots>();

    public static SlotsContainer Load(string path)
    {
        TextAsset xmlFile = Resources.Load<TextAsset>(path);
        Debug.Log(xmlFile);
        XmlSerializer serializer = new XmlSerializer(typeof(SlotsContainer));
        StringReader reader = new StringReader(xmlFile.text);


        SlotsContainer slots = serializer.Deserialize(reader) as SlotsContainer;

        reader.Close();


        return slots;
    }
	

}
