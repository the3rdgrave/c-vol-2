using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interact : MonoBehaviour {

    public string InteractButton;
    public float RayDistance = 3f;

    public LayerMask InteractLayer; //Layer

    public Image InteractImage; // hand picture

    public bool isInteractable;

	// Use this for initialization
	void Start () {
        //set hand to be invisible
        if (InteractImage != null)
        {
            InteractImage.enabled = false;
        } 

	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Map.mapp == null)
        {
            Map.mapDestroy = true;
        }
        //shoot a ray
        if (Physics.Raycast(ray,out hit,RayDistance, InteractLayer))
        {
            //check if there is no interaction
            if(isInteractable == false)
            {
                if(InteractImage != null)
                {
                    InteractImage.enabled = true;
                }

                //if the button is pressed
                if (Input.GetButtonDown(InteractButton))
                {
                    // checks if it is a door
                    if (hit.collider.CompareTag("Door"))
                    {
                        //Open and close the door

                        hit.collider.GetComponent<Door>().ChangeDoorState();
                    }
                    else if (hit.collider.CompareTag("Key"))
                    {
                        hit.collider.GetComponent<Key>().UnlockDoor();
                    }
                    else if (hit.collider.CompareTag("Map"))
                    {
                        hit.collider.GetComponent<Map>().UnlockNextLevel();
                    }
                    else if (hit.collider.CompareTag("Boat"))
                    {
                        // if(myBoat.isLocked == false)
                        hit.collider.GetComponent<Boat>().ChangeBoatState();
                    } else if (hit.collider.CompareTag("Safe")) {
                        //show safe Ui
                        hit.collider.GetComponent<Safe>().EnableSafeCanvas();
                    }




                }
            }
        }
        else
        {
            InteractImage.enabled = false;
        }
	}
}
