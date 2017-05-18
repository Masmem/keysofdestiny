using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml.Serialization;
using System.IO;

[XmlRoot("SkillsCollection")]
public class SkillsContainer {


    [XmlArray("Skills")]




    public static SkillsContainer Load(string path)
    {
        TextAsset xmlFile = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(SkillsContainer));
        StringReader reader = new StringReader(xmlFile.text);



        SkillsContainer ataqueBasicos = serializer.Deserialize(reader) as SkillsContainer;
        reader.Close();

        return ataqueBasicos;
    }




}
