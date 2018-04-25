using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSevenEnabler : MonoBehaviour {
    public Button myButton;
    // Use this for initialization
    void Start()
    {
        myButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetInt("Level7") == 1)
        {
            myButton.interactable = true;
        }
        else
        {
            myButton.interactable = false;
        }
    }
}
