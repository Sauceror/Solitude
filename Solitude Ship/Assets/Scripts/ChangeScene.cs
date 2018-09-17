
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

   [SerializeField] private string  changeLevel;
    void OnCollisionEnter2D(Collision2D col)
    {



        if (col.gameObject.tag == "Key")
        {


            SceneManager.LoadScene(changeLevel);
        }
    }

}