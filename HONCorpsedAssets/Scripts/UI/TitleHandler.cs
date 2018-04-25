using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleHandler : MonoBehaviour {

    public GameManager game;

    public void OpenOptions()
    {
        game.OpenOptions();
    }

    public void QuitGame()
    {
        game.QuitGame();
    }

    public void NewGame()
    {
        game.NewGame();
    }
}
