using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassList : MonoBehaviour {
    public string path;
    public GameObject classePrefab;

    private int count = 0;


    private ToggleGroup groupClasses;


	// Use this for initialization
	void Start () {
        ClassesContainer classes = ClassesContainer.Load(path);
        groupClasses = GetComponent<ToggleGroup>();

        foreach (Classes classe in classes.classes)
        {
           
        

            GameObject classeSlot = Instantiate(classePrefab, this.gameObject.transform);
            classeSlot.transform.SetParent(this.transform);
            Toggle tgClasse = classeSlot.GetComponent<Toggle>();
            tgClasse.group = groupClasses;
            tgClasse.GetComponentInChildren<Text>().text = classe.clName.ToString();
            if (!classe.isActivated)
            {
                tgClasse.interactable = false;
            }
            if (count == 0)
            {
                tgClasse.isOn = true;
               
            }
            count++;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
