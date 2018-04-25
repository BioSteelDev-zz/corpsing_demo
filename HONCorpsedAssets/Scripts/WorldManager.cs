using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour {

    /* This script will handle the level and player */
    public GameObject Player;
    public GameObject[] Levels;
    private Vector3 StartPos;

	// Use this for initialization
	void Start () {
        StartPos = new Vector3(-9.0f, -4.0f, 0.0f);
        //Instantiate(Player, StartPos, Quaternion.identity);
	}
    public void CreateNewPlayer()
    {
        Invoke("CreatePlayerInstance", 1.0f);
    }

    void CreatePlayerInstance()
    {
        StartPos = new Vector3(-9.0f, -4.0f, 0.0f);
        Instantiate(Player, StartPos, Quaternion.identity);
    }

    public void LevelOne()
    {
        Instantiate(Levels[0]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if(PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }

        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }

        if (Selector != null)
           Destroy(Selector);

        CreatePlayerInstance();
    }

    public void LevelTwo()
    {
        Instantiate(Levels[1]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }
        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }
        if (Selector != null)
            Destroy(Selector);

        CreatePlayerInstance();
    }

    public void LevelThree()
    {
        Instantiate(Levels[2]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }
        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }
        
        if (Selector != null)
            Destroy(Selector);

        CreatePlayerInstance();
    }

    public void LevelFour()
    {
        Instantiate(Levels[3]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }
        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }
        
        if (Selector != null)
            Destroy(Selector);

        CreatePlayerInstance();
    }

    public void LevelFive()
    {
        Instantiate(Levels[4]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }
        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }
        
        if (Selector != null)
            Destroy(Selector);

        CreatePlayerInstance();
    }

    public void LevelSix()
    {
        Instantiate(Levels[5]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }
        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }
        
        if (Selector != null)
            Destroy(Selector);

        CreatePlayerInstance();
    }

    public void LevelSeven()
    {
        Instantiate(Levels[6]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }
        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }
        
        if (Selector != null)
            Destroy(Selector);

        CreatePlayerInstance();
    }

    public void LevelEight()
    {
        Instantiate(Levels[7]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }
        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }
        
        if (Selector != null)
            Destroy(Selector);

        CreatePlayerInstance();
    }

    public void LevelNine()
    {
        Instantiate(Levels[8]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }
        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }
        
        if (Selector != null)
            Destroy(Selector);

        CreatePlayerInstance();
    }

    public void LevelTen()
    {
        Instantiate(Levels[9]);
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject Selector = GameObject.FindGameObjectWithTag("LevelSelect");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }
        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }
        
        if (Selector != null)
            Destroy(Selector);

        CreatePlayerInstance();
    }
}
