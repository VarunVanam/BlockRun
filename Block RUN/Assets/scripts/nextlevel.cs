﻿
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextlevel : MonoBehaviour {

    public void loadnextlevel()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}