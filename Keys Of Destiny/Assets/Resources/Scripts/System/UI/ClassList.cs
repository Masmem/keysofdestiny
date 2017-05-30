using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ClassList : MonoBehaviour {
    public string path;
    public string pathSkill;

    
    public GameObject classePrefab;
    private SkillsContainer allSkills;
    private int count = 0;

    public Sprite[] iconesClasses;


    private ToggleGroup groupClasses;


	// Use this for initialization
	void Start () {
        ClassesContainer classes = ClassesContainer.Load(path);
        allSkills = SkillsContainer.Load(pathSkill);
        groupClasses = GetComponent<ToggleGroup>();

        foreach (Classes classe in classes.classes)
        {
            GameObject classeSlot = Instantiate(classePrefab, this.gameObject.transform);
            SkillManager sm = classeSlot.GetComponent<SkillManager>();

            sm.CodClasse = classe.clCodClass;
            

            classeSlot.transform.SetParent(this.transform);
            Toggle tgClasse = classeSlot.GetComponent<Toggle>();

            tgClasse.GetComponentInChildren<Image>().sprite = iconesClasses[count];
            tgClasse.group = groupClasses;
            tgClasse.GetComponentInChildren<Text>().text = classe.clName.ToString();

            if (!classe.isActivated)
            {
                tgClasse.interactable = false;
            }
            if (count == 0)
            {
                tgClasse.isOn = true;
                TrocarSkills(sm.CodClasse);
               
            }
            count++;
        }

	}
	
	// Update is called once per frame
	void Update () {

	}


    public Toggle[] ataquesPrimario;
    public Toggle[] ataqueSecundario;
    public Toggle[] skills;
    public Toggle[] movementsSkill;

    public void TrocarSkills(string codeClasse)
    {
        //SkillsContainer tempList = allSkills;

        TrocarInformacoes(allSkills.ataqueBasicos, ataquesPrimario, codeClasse);
        TrocarInformacoes(allSkills.ataqueSecundarios, ataqueSecundario, codeClasse);
        TrocarInformacoes(allSkills.skills, skills, codeClasse);
        TrocarInformacoes(allSkills.skillsMovement, movementsSkill, codeClasse);



        
    }



    void TrocarInformacoes(List<Skills> skills, Toggle[] slots,string codeClasse)
    {
        int count = 0;

        foreach (Skills skill in skills)
        {

            if (skill.codClasse == codeClasse)
            {
                Text[] texts = slots[count].GetComponentsInChildren<Text>();
                texts[0].text = skill.nomeSkill.ToString();
                texts[1].text = skill.descSkill.ToString();
                // tempList.skillsMovement.Remove(skill);

                count++;
            }
        }
    }

}
