using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{

    public bool open = false; //door state
    public GameObject WinUI;

    private AudioSource audioSource;
    public AudioClip openingSound;

    public AudioClip LockedSound;

    public bool isLocked = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void ChangeBoatState()
    {
        if (isLocked != true)
        {
            //  open = !open;

            //win UI condition
                WinUI.SetActive(true);
            
           

           
            if (audioSource != null)
            {
                audioSource.PlayOneShot(openingSound);
            }

        }
        else
        {
            PlayLockedDoorSound();
            //lose UI condition
        }
    }

    void PlayLockedDoorSound()
    {
        audioSource.PlayOneShot(LockedSound);
    }
    // Update is called once per frame
    // void Update()
    // {
    //   if (open)
    //  {
    //      WinUI.SetActive(true);
    //  }
    //   else
    //    {
    //   
    //  }
    //}
    public void GameWon()
    {
        if (Map.mapDestroy == true)
        {
            WinUI.SetActive(true);
        }else
        {

        }
    }
}