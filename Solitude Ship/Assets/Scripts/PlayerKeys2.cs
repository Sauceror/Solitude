using UnityEngine;

public class PlayerKeys2 : MonoBehaviour {

    public GameObject door;
    public GameObject key;


    
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Key3")
        {

            Destroy(door);
            Destroy(key);
        
    }
		
	}
}
