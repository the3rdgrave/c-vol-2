using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
namespace Interaction
{
    public class ShootRay : MonoBehaviour
    {
        private float Frate = 0.3f;
        private float nextFire;
        private RaycastHit hit;
        private float range = 5;
        private Transform myTransform;

        // Use this for initialization
        void Start()
        {
            SetInitialReferences();
        }

        // Update is called once per frame
        void Update()
        {
            CheckforInput();
        }

        void SetInitialReferences()
        {
            myTransform = transform;
        }

        void CheckforInput()
        {
            /*   if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
               {
                   nextFire = Time.time + Frate;
                   Debug.Log("Key Pressed");

       */
              if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.E)  && Time.time > nextFire)
                 {
                Debug.DrawRay(myTransform.TransformPoint(0,0,1), myTransform.forward, Color.white, 3);
                if(Physics.Raycast(myTransform.TransformPoint(0, 0, 1), myTransform.forward,out hit, range))
                {
                    Debug.Log(hit.transform.name);
                    if (hit.transform.tag == "chest")
                    {
                        print("hits");
                      //  if()
                        hit.transform.GetComponent<Animator>().SetTrigger("Open chest");
                      //  hit.transform.GetComponent<Animator>().SetTrigger("Open Door");
                      //  hit.transform.GetComponent<Animator>().SetTrigger("Open Door2");
                        hit.transform.GetComponent<Animator>().SetTrigger("Panw Ntoulapi");
                        hit.transform.GetComponent<Animator>().SetTrigger("katw ntoulapi");
                        hit.transform.GetComponent<Animator>().SetTrigger("Surtari");
                    }
                    
                }
                     nextFire = Time.time + Frate;
                   //  Debug.Log("Key Pressed");
             }
             }
         }

     }

