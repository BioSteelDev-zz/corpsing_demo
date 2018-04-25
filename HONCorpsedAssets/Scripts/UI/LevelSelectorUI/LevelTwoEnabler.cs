using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelTwoEnabler : MonoBehaviour {
    public Button myButton;
	// Use this for initialization
	void Start () {
        myButton = GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
        
		if(PlayerPrefs.GetInt("Level2") == 1)
        {
            myButton.interactable = true;
        }
        else
        {
            myButton.interactable = false;
        }
	}
}
