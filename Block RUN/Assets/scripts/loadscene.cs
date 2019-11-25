using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadscene : MonoBehaviour
{

    [SerializeField] private string loadlevel;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PLayer"))
        {
            SceneManager.LoadScene(loadlevel);
        }
    }


}
