using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour {
    [Header("XLM Path")]
    public string path;



	// Use this for initialization
	void Start () {
        SlotsContainer slots = SlotsContainer.Load(path);

        foreach (Slots slot in slots.slots)
        {
            //print(slot.numSlot);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}







}
