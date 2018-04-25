using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsHandler : MonoBehaviour {

    public GameObject TitleObject;

    //return to main menu
    public void ReturnToMain()
    {

        //Remove all objects in scene
        GameObject PlayerCheck = GameObject.FindGameObjectWithTag("Player");
        GameObject[] Bodies = GameObject.FindGameObjectsWithTag("Body");
        if (PlayerCheck != null)
        {
            Destroy(PlayerCheck);
        }

        foreach (GameObject body in Bodies)
        {
            Destroy(body);
        }

        Destroy(GameObject.FindGameObjectWithTag("WorldObject"));

        if (GameObject.FindGameObjectWithTag("1"))
        {
            Destroy(GameObject.FindGameObjectWithTag("1"));
        }
        else if (GameObject.FindGameObjectWithTag("2"))
        {
            Destroy(GameObject.FindGameObjectWithTag("2"));
        }
        else if (GameObject.FindGameObjectWithTag("3"))
        {
            Destroy(GameObject.FindGameObjectWithTag("3"));
        }
        else if (GameObject.FindGameObjectWithTag("4"))
        {
            Destroy(GameObject.FindGameObjectWithTag("4"));
        }
        else if (GameObject.FindGameObjectWithTag("5"))
        {
            Destroy(GameObject.FindGameObjectWithTag("5"));
        }
        else if (GameObject.FindGameObjectWithTag("6"))
        {
            Destroy(GameObject.FindGameObjectWithTag("6"));
        }
        else if (GameObject.FindGameObjectWithTag("7"))
        {
            Destroy(GameObject.FindGameObjectWithTag("7"));
        }
        else if (GameObject.FindGameObjectWithTag("8"))
        {
            Destroy(GameObject.FindGameObjectWithTag("8"));
        }
        else if (GameObject.FindGameObjectWithTag("9"))
        {
            Destroy(GameObject.FindGameObjectWithTag("9"));
        }
        else if (GameObject.FindGameObjectWithTag("10"))
        {
            Destroy(GameObject.FindGameObjectWithTag("10"));
        }
        //Create Title Object
        Instantiate(TitleObject);
        //Destroy this
        Destroy(GameObject.FindGameObjectWithTag("OptionsObject"));

    }
    //return to game
    public void CloseOptions() {
        Destroy(this.gameObject);
    }
}
