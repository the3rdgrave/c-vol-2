using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.ImageEffects;

public class Safe : MonoBehaviour {

  // public GameObject Map;
  //  public float speed = 2f;
    public Canvas SafeCanvas;
    public GameObject playerObject;

    private int number1 =1;
    private int number2 =1;
    private int number3 =1;
    private int number4 =1;

    public Text textNumber1;
    public Text textNumber2;
    public Text textNumber3;
    public Text textNumber4;

    public bool opened;

    // Use this for initialization
    void Start()
    {
        opened = false;
        SafeCanvas.enabled = false;
        //enable players control
    }
    public void EnableSafeCanvas()
    {
        SafeCanvas.enabled = true;
        //disable players control
        playerObject.GetComponent<FirstPersonController>().enabled = false;

        //unlocks mouse
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            playerObject.GetComponent<FirstPersonController>().enabled = true;
            SafeCanvas.enabled = false;
        }
        //Putting the password number
        if(number1 == 5 && number2 == 5 && number3 == 7 && number4 == 5)
        {
            opened = true;
          
        }

        if(opened == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            playerObject.GetComponent<FirstPersonController>().enabled = true;
            SafeCanvas.enabled = false;

            gameObject.layer = 0;
            UnlockSafe();
        }
	}

    void UnlockSafe()
    {
      //  Map.transform.Translate(Map.transform.forward * speed);
        GetComponent<Animator>().SetTrigger("Surtari");
       // Transform.Translate
    }

    public void IncreaseNumber(int Number)
    {
        if (Number == 1)
        {
            number1++;
            textNumber1.text = number1.ToString();

            if(number1 > 9)
            {
                number1 = 0;
                textNumber1.text = number1.ToString();
            }
        }
        else if (Number == 2)
        {
            number2++;
            textNumber2.text = number2.ToString();

            if (number2 > 9)
            {
                number2 = 0;
                textNumber2.text = number2.ToString();
            }
        }
        else if (Number == 3)
        {
            number3++;
            textNumber3.text = number3.ToString();

            if (number3 > 9)
            {
                number3 = 0;
                textNumber3.text = number3.ToString();
            }
        }
        else if (Number == 4)
        {
            number4++;
            textNumber4.text = number4.ToString();

            if (number4 > 9)
            {
                number4 = 0;
                textNumber4.text = number4.ToString();
            }
        }
    }
    public void DecreaseNumber(int Number)
    {
        if (Number == 1)
        {
            number1--;
            textNumber1.text = number1.ToString();

            if (number1 < 0)
            {
                number1 = 9;
                textNumber1.text = number1.ToString();
            }
        }
        else if (Number == 2)
        {
            number2--;
            textNumber2.text = number2.ToString();

            if (number2 < 0)
            {
                number2 = 9;
                textNumber2.text = number2.ToString();
            }
        }
        else if (Number == 3)
        {
            number3--;
            textNumber3.text = number3.ToString();

            if (number3 < 0)
            {
                number3 = 9;
                textNumber3.text = number3.ToString();
            }
        }
        else if (Number == 4)
        {
            number4--;
            textNumber4.text = number4.ToString();

            if (number4 < 0)
            {
                number4 = 9;
                textNumber4.text = number4.ToString();
            }
        }
    }
}
