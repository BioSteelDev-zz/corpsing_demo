using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour {

    public GameObject CompleteText;
    public WorldManager WorldScript;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.Equals("GroundCheck"))
        {
            DisplayComplete();
            Destroy(collision.gameObject);
        }
    }

    public void DisplayComplete()
    {
        Instantiate(CompleteText, new Vector3(0.0f, 0.0f, -10.0f), Quaternion.identity);
        Invoke("NextLevel", 3.0f);
    }

    public void NextLevel()
    {
        Destroy(GameObject.FindGameObjectWithTag("CompleteText"));
        if (GameObject.FindGameObjectWithTag("1"))
        {
            PlayerPrefs.SetInt("Level2", 1);
            PlayerPrefs.Save();
            Destroy(GameObject.FindGameObjectWithTag("1"));
            WorldScript.LevelTwo();
        }
        else if (GameObject.FindGameObjectWithTag("2"))
        {
            PlayerPrefs.SetInt("Level3", 1);
            PlayerPrefs.Save();
            Destroy(GameObject.FindGameObjectWithTag("2"));
            WorldScript.LevelThree();
        }
        else if (GameObject.FindGameObjectWithTag("3"))
        {
            PlayerPrefs.SetInt("Level4", 1);
            PlayerPrefs.Save();
            Destroy(GameObject.FindGameObjectWithTag("3"));
            WorldScript.LevelFour();
        }
        else if (GameObject.FindGameObjectWithTag("4"))
        {
            PlayerPrefs.SetInt("Level5", 1);
            PlayerPrefs.Save();
            Destroy(GameObject.FindGameObjectWithTag("4"));
            WorldScript.LevelFive();
        }
        else if (GameObject.FindGameObjectWithTag("5"))
        {
            PlayerPrefs.SetInt("Level6", 1);
            PlayerPrefs.Save();
            Destroy(GameObject.FindGameObjectWithTag("5"));
            WorldScript.LevelSix();
        }
        else if (GameObject.FindGameObjectWithTag("6"))
        {
            PlayerPrefs.SetInt("Level7", 1);
            PlayerPrefs.Save();
            Destroy(GameObject.FindGameObjectWithTag("6"));
            WorldScript.LevelSeven();
        }
        else if (GameObject.FindGameObjectWithTag("7"))
        {
            PlayerPrefs.SetInt("Level8", 1);
            PlayerPrefs.Save();
            Destroy(GameObject.FindGameObjectWithTag("7"));
            WorldScript.LevelEight();
        }
        else if (GameObject.FindGameObjectWithTag("8"))
        {
            PlayerPrefs.SetInt("Level9", 1);
            PlayerPrefs.Save();
            Destroy(GameObject.FindGameObjectWithTag("8"));
            WorldScript.LevelNine();
        }
        else if (GameObject.FindGameObjectWithTag("9"))
        {
            PlayerPrefs.SetInt("Level10", 1);
            PlayerPrefs.Save();
            Destroy(GameObject.FindGameObjectWithTag("9"));
            WorldScript.LevelTen();
        }
        else if (GameObject.FindGameObjectWithTag("10"))
        {
            Application.Quit();
        }
        else
        {

        }

    }
}
