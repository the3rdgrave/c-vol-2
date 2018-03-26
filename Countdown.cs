using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
    public static float timer = 300f;
    private Text Seconds;
    

    // Use this for initialization
    void Start ()
    {
        ResetVariables();
        Seconds = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // timer -= Time.deltaTime;
        float t = timer - Time.time;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        Seconds.text = minutes + ":" + seconds;
        /* if(timer <= 0)
         {

         }*/
    }

    public void ResetVariables()
    {
        timer = 300f;
    }


}
