using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string LevelToLoad = "Main Level";

    public SceneFader sceneFader;

	public void Play()
    {
        sceneFader.FadeTo(LevelToLoad);
    }

    public void SceneSelector()
    {
        sceneFader.FadeTo(LevelToLoad);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
