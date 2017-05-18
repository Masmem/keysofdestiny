using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SkillManager : MonoBehaviour {
    public string path;
    private SkillsContainer skills;
    private Toggle tg;

	// Use this for initialization
	void Start () {
        tg = GetComponent<Toggle>();
        skills = SkillsContainer.Load(path);
        
	}
	
	// Update is called once per frame
	void Update () {
        if (tg.isOn)
        {
            Testando("1");
        }
		
	}


    public void Testando(string codeClass)
    {
        foreach(Skills skill in skills.ataqueBasicos)
        {
            print(skill.descSkill);
        }
    }


    


}
