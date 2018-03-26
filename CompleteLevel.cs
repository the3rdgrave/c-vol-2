﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour {
    public string menuSceneName = "MainMenu";
    public SceneFader sceneFader;
	
    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }

}
