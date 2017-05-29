using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour {

    //public Image nextPanel; //próximo painel a ser visualizado
    //public Image backPanel; // painel anterior



    public void NextPanel(Image nextPanel)
    {
        nextPanel.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

   





}
