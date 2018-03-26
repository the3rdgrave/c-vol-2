using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public Door myDoor;

    private AudioSource audioSource;
    public AudioClip KeyPickUpSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    public void UnlockDoor()
    {
        myDoor.isLocked = false;
        
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
