using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool GameIsOver = false;
    public GameObject gameOverUI;
   // public GameObject WinUI;
	

    void Update()
    {
        if (GameIsOver)
            return;

        if (Countdown.timer <= 0)
        {
            EndGame();
        }
    }
	void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinGame()
    {
        GameIsOver = true;
        //WinUI.SetActive(true);
    }
}
