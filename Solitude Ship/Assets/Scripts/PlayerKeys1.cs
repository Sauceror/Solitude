using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeys1 : MonoBehaviour {

    public  GameObject door;
    public  GameObject key;
    public  GameObject key2;
    public GameObject door2;


    
        void OnCollisionEnter2D(Collision2D col)
    {



            if (col.gameObject.tag == "Key2")
            {


                Destroy(door2);
                Destroy(key2);
                return;
            }
        }
    }

