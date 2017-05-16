using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml.Serialization;
using System.IO;

[XmlRoot("ClassesCollection")]
public class ClassesContainer{

    [XmlArray("Classes")]
    [XmlArrayItem("Classe")]
    public List<Classes> classes = new List<Classes>();

    public static ClassesContainer Load(string path)
    {

        //StreamReader xmlFile = File.OpenText(Application.dataPath.ToString() + path);
        //Resources.Load("Script/" + path);
        // Debug.Log(xmlFile);

        TextAsset xmlFile = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(ClassesContainer));
        StringReader reader = new StringReader(xmlFile.text);


        ClassesContainer classes = serializer.Deserialize(reader) as ClassesContainer;

        reader.Close();


        return classes;
    }




}
