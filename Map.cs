using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    public Boat myBoat;
    public static   GameObject mapp;
    private AudioSource audioSource;
    public AudioClip KeyPickUpSound;
    public static bool mapDestroy = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
   

    public void UnlockNextLevel()
    {
        myBoat.isLocked = false;

        audioSource.PlayOneShot(KeyPickUpSound);
        StartCoroutine("WaitForSelfDestruct");

    }

    IEnumerator WaitForSelfDestruct()
    {
        yield return new WaitForSeconds(KeyPickUpSound.length);
        Remove();
    }
    public void Remove()
    {
        Destroy(gameObject);
    }


}
