using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class SkillManager : MonoBehaviour, ISelectHandler {
    public string path;
    private SkillsContainer skills;
    private Toggle tg;

    private string codClasse;

	// Use this for initialization
	void Start () {
        tg = GetComponent<Toggle>();
        skills = SkillsContainer.Load(path);
        
	}
	
	// Update is called once per frame
	void Update () {

		
	}


    public void TrocarSkills(string codeClass)
    {
        foreach(Skills skill in skills.ataqueBasicos)
        {
            print(skill.descSkill);
        }
    }

    

    public void OnSelect(BaseEventData eventData)
    {
       GetComponentInParent<ClassList>().TrocarSkills(CodClasse);
    }


    public string CodClasse
    {
        get
        {
            return codClasse;
        }

        set
        {
            codClasse = value;
        }



    }

}
