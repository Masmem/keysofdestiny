using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeUi : MonoBehaviour {
    public float tempoFadeIn;
    public float tempoFadeOut;

   private Graphic uiElement;


    //Use this for initialization
	void Start () {
       uiElement = GetComponent<Graphic>();
        InvokeRepeating("Piscar", 1, tempoFadeOut + tempoFadeIn);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void FadeIn(Graphic uiElement, float time)
    {
        uiElement.CrossFadeAlpha(0.01f, time, false);

    }

    public static void FadeOut(Graphic uiElement, float time)
    {
        //fade.color = new Color(0, 0, 0, 0);
        uiElement.CrossFadeAlpha(1f, time, false);
   

    }


    public void Piscar()
    {
        StartCoroutine("PiscarUi");
    }

    IEnumerator PiscarUi()
    {
  
        uiElement.CrossFadeAlpha(0.1f,tempoFadeIn,false);
        yield return new WaitForSeconds(tempoFadeIn);
        uiElement.CrossFadeAlpha(1, tempoFadeOut, false);
    }



}
