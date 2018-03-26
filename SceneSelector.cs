using UnityEngine;

public class SceneSelector : MonoBehaviour {

    public SceneFader fader;

	public void Select(string LevelName)
    {
        fader.FadeTo(LevelName);
    }
}
