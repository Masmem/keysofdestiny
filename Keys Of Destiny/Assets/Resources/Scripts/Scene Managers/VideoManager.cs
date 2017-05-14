using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour {
    public MovieTexture video;

   


    // Use this for initialization
    void Start () {
        video = (MovieTexture) GetComponent<RawImage>().mainTexture;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public MovieTexture Video
    {
        get
        {
            return video;
        }

        set
        {
            video = value;
        }
    }


}
