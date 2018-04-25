using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public GameObject TitleObject; // Handles title screen, initializes GameObject on game start
    public GameObject AudioObject; // Handles Audio
    public GameObject GameObject; // Holds a Player Object and Level Object
    public GameObject OptionsObject;

	// Use this for initialization
	void Start () {
        LoadTitle();
        LoadAudio();
        //UnlocksSet();
	}
	
    //Create the 'Game Manager' Object, that holds the player and levels
    public void NewGame()
    {
        Instantiate(GameObject);

        GameObject[] item = GameObject.FindGameObjectsWithTag("TitleObject");
        Destroy(item[0]);
    }
    
    //Load the title screen
    void LoadTitle()
    {
        Instantiate(TitleObject);
    }

    //Load the Audio Manager
    void LoadAudio()
    {
        Instantiate(AudioObject);
    }

    //QuitGameOnClick
    public void QuitGame()
    {
        Application.Quit();
    }

    //Open the options menu and hide the titleobject
    public void OpenOptions()
    {
        GameObject[] item = GameObject.FindGameObjectsWithTag("TitleObject");
        Destroy(item[0]);

        Instantiate(OptionsObject);
    }

    //Unhide the title menu and destroy the optionsobject
    public void CloseOptions()
    {
        Instantiate(TitleObject);

        GameObject[] otheritem = GameObject.FindGameObjectsWithTag("OptionsObject");
        Destroy(otheritem[0]);

    }

    void UnlocksSet()
    {
        PlayerPrefs.SetInt("Level2", 0);
        PlayerPrefs.SetInt("Level3", 0);
        PlayerPrefs.SetInt("Level4", 0);
        PlayerPrefs.SetInt("Level5", 0);
        PlayerPrefs.SetInt("Level6", 0);
        PlayerPrefs.SetInt("Level7", 0);
        PlayerPrefs.SetInt("Level8", 0);
        PlayerPrefs.SetInt("Level9", 0);
        PlayerPrefs.SetInt("Level10", 0);
    }
}
