/*
GUINotes.cs - wirted by ThunderWire Games * Script for Interact Notes
*/

using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class GUINotes : MonoBehaviour {

public float PickupRange = 3f;

private bool pressedButton = false;
private bool backNotes = false;

//private Ray playerAim;
private Camera playerCam;
public GameObject NoteObject;
//private GameObject NoteObject2;

	void FixedUpdate () {
		if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.E)){ 

            pressedButton = true;
		}
	}
	
	void Update () {
		playerCam = Camera.main;
		Ray playerAim = playerCam.GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
		RaycastHit hit;

		if (Physics.Raycast (playerAim, out hit, PickupRange)){
			if (hit.collider.tag == "Note"){
				NoteObject = hit.collider.gameObject;
				if(pressedButton && (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.E))){
					NoteObject.GetComponent<Notes>().ShowNotes();
                 //   NoteObject2.GetComponent<Notes>().ShowNotes();
                    this.GetComponent<Blur>().enabled = true;
					backNotes = false;
					pressedButton = false;
				}
			}
		}
		if(backNotes){
			NoteObject.GetComponent<Notes>().BackNotes();
			this.GetComponent<Blur>().enabled = false;
			backNotes = false;
			pressedButton = false;
		}
    }
	
	public void Back() {
		backNotes = true;
	}
}