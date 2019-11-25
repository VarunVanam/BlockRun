using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movescenetrigger : MonoBehaviour
{
    [SerializeField]private string loadlevel;


    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PLayer"))
        {
            SceneManager.LoadScene(loadlevel);
        }
    }
    
       
    
}
