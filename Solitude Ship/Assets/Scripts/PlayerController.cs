using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public float movementForce = 100f;
    public float movementForce2 = -100f;
    public float superMove = 100f;
    public GameObject door2;
    public GameObject key2;
    public GameObject key1;
    public Rigidbody2D rb;
    public bool isGrounded = true;
    public GameObject key;




    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(Input.GetAxis("Vertical") * Vector3.down * movementForce * Time.deltaTime);
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * movementForce * Time.deltaTime);




    }
    void OnCollisionEnter2D(Collision2D col)
    {



        if (col.gameObject.tag == "Key")
        {


            Destroy(door2);
            Destroy(key);
            
        }



    }
    
    }



        
	
    

    

