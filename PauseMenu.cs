using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject UI;
    public string menuSceneName = "MainMenu";
    public SceneFader sceneFader;

	// Update is called once per frame
	void Update () {
       // Input.GetKeyDown(KeyCode.Escape) ||
        if ( Input.GetKeyDown(KeyCode.P))
        {
            Toggle_PauseMenu();
            Cursor.visible = (true);
            Cursor.lockState = CursorLockMode.None;

        }
	}

    public void Toggle_PauseMenu()
    {
        UI.SetActive(!UI.activeSelf);
        if (UI.activeSelf)
        {
            Time.timeScale = 0f;
            


        }
        else
            Time.timeScale = 1f;
    }
    
    public void Restart()
    {
        Toggle_PauseMenu();
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        
    }
    public void MainMenu()
    {
        Toggle_PauseMenu();
        Debug.Log("MainMenu Enabled");
        sceneFader.FadeTo(menuSceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    /*  void cursor()
      {
          Cursor.visible = false;
      } */
}
