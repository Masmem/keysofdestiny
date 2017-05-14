using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Intro : MonoBehaviour {
    public MovieTexture intro;
    public float tempoFadeIn;
    public float tempoFedeOut;

    public Image fade;

	// Use this for initialization
	void Start () {
        intro = (MovieTexture) GetComponent<Graphic>().mainTexture;
        StartCoroutine("TrocarCena");
    }
	
	// Update is called once per frame
	void Update () {

    }
    
    IEnumerator TrocarCena()
    {
        FadeUi.FadeIn(fade,tempoFadeIn);
        //fade.CrossFadeAlpha(0.01f, 2, false);
        intro.Play();
        yield return new WaitForSeconds(intro.duration);
        FadeUi.FadeOut(fade, tempoFedeOut);
        yield return new WaitForSeconds(tempoFedeOut);
        SceneManager.LoadScene("FirstScreen");
    }
   


}
