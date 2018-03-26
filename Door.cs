using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool open = false; //door state

    public float doorOpenAngle = 90f;
    public float doorClosedAngle = 0f;

    public float speed = 2f;

    private AudioSource audioSource;
    public AudioClip openingSound;
    
    public AudioClip LockedSound;

    public bool isLocked = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    public void ChangeDoorState()
    {
        if (isLocked != true)
        {
            open = !open;


            if (audioSource != null)
            {
                audioSource.PlayOneShot(openingSound);
            }

        }
        else
        {
            PlayLockedDoorSound();
        }
    }
     
    void PlayLockedDoorSound()
    {
        audioSource.PlayOneShot(LockedSound);
    }
	// Update is called once per frame
	void Update () {
        if (open)
        {
            Quaternion targetRotationOpen = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, speed * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotationClose = Quaternion.Euler(0, doorClosedAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationClose, speed * Time.deltaTime);
        }
	}
}
